using WorkoutTracker.Api.Models;

namespace WorkoutTracker.Api.Services;

public class WorkoutRepository
{
    private static readonly List<Workout> _workouts = new();   

    public void Add(Workout workout)
    {
        _workouts.Add(workout);
    }        

    public List<Workout> GetAll()
    {
        return _workouts;
    }   
}