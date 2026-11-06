using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables for the Resume class
    public string _name = "";
    
    // List to hold multiple Job instances, initialized right away
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume name and all associated jobs
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        // Iterate through each job in the list and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}