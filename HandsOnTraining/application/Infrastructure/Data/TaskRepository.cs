using System;
using System.Collections.Generic;
using RaviDataGlobe.HandsOnTraining.Core.Domain;
using RaviDataGlobe.HandsOnTraining.Core.Interfaces.Data;

namespace RaviDataGlobe.HandsOnTraining.Infrastructure.Data
{
    public class TaskRepository : ITaskRepository
    {
        private static readonly IEnumerable<Task> _allTasks = new[]
            {
                new Task
                    {
                       Description = "My first task",
                       Expires = new DateTime(2015,01,01)
                    },

                     new Task
                    {
                       Description = "My second task",
                       Expires = new DateTime(2013,08,21)
                    },

                     new Task
                    {
                       Description = "My third and last task",
                       Expires = DateTime.Now.AddMinutes(10)

                    }
            };
        public IEnumerable<Task> GetAll()
        {
            return _allTasks;
        }
    }
}