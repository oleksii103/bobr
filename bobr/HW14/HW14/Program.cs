using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Training
{
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public double DurationMinutes { get; set; }
    public double? DistanceKm { get; set; }
    public int Calories { get; set; }
}

public class FitnessTrackerService
{
    private List<Training> trainings;
    private readonly string filePath = "trainings.dat";

    public FitnessTrackerService()
    {
        trainings = new List<Training>();
        LoadFromFile();
    }

    public void AddTraining(Training training)
    {
        trainings.Add(training);
        SaveToFile();
    }

    public bool EditTraining(DateTime date, string type, Training updated)
    {
        var existing = trainings.FirstOrDefault(t => t.Date.Date == date.Date && string.Equals(t.Type, type, StringComparison.OrdinalIgnoreCase));
        if (existing == null) return false;

        existing.Type = updated.Type;
        existing.Date = updated.Date;
        existing.DurationMinutes = updated.DurationMinutes;
        existing.DistanceKm = updated.DistanceKm;
        existing.Calories = updated.Calories;

        SaveToFile();
        return true;
    }

    public bool DeleteTraining(DateTime date, string type)
    {
        var training = trainings.FirstOrDefault(t => t.Date.Date == date.Date && string.Equals(t.Type, type, StringComparison.OrdinalIgnoreCase));
        if (training == null) return false;

        trainings.Remove(training);
        SaveToFile();
        return true;
    }

    public List<Training> SearchByDate(DateTime date)
    {
        return trainings.Where(t => t.Date.Date == date.Date).ToList();
    }

    public List<Training> SearchByType(string type)
    {
        return trainings.Where(t => string.Equals(t.Type, type, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public (int Count, double TotalTime, double TotalDistance, int TotalCalories) GetStatistics(DateTime from, DateTime to)
    {
        var filtered = trainings.Where(t => t.Date.Date >= from.Date && t.Date.Date <= to.Date);
        int count = filtered.Count();
        double totalTime = filtered.Sum(t => t.DurationMinutes);
        double totalDistance = filtered.Sum(t => t.DistanceKm ?? 0);
        int totalCalories = filtered.Sum(t => t.Calories);
        return (count, totalTime, totalDistance, totalCalories);
    }

    private void SaveToFile()
    {
        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
#pragma warning disable SYSLIB0011
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, trainings);
#pragma warning restore SYSLIB0011
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }

    private void LoadFromFile()
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
#pragma warning disable SYSLIB0011
                    BinaryFormatter formatter = new BinaryFormatter();
                    trainings = (List<Training>)formatter.Deserialize(fs);
#pragma warning restore SYSLIB0011
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data: {ex.Message}");
            trainings = new List<Training>();
        }
    }
}
