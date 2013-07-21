using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RaviDataGlobe.HandsOnTraining.Core.Interfaces.Data;

namespace RaviDataGlobe.HandsOnTraining.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public TasksController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        //
        // GET: /Tasks/

        public ActionResult Index()
        {
            var tasks =_taskRepository.GetAll();

            return View(tasks);
        }

    }
}
