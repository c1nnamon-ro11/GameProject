using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebInterfaceGame.Models;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace WebInterfaceGame.Controllers
{
    public class GameController : Controller
    {
        private List<ViewModel> gameElements = ViewModel.GameUnits;
        private List<string> result = ViewModel.Scoreboard;
        ProcessStartInfo infoStartProcess = new ProcessStartInfo();

        public ActionResult Briefing()
        {
            return View("Briefing", gameElements);
        }
        public ActionResult Rules()
        {
            return View("Rules", gameElements);
        }

        public ActionResult Scoreboard()
        {
            string str = Server.MapPath("~/bin/Content/Scoreboard/Scoreboard.txt");
            StreamReader sr = new StreamReader(str);
            List<string> result = new List<string>();
            while (!sr.EndOfStream)
            {
                result.Add(sr.ReadLine());
            }
            ViewModel.Scoreboard = result;
            sr.Close();           
            /*return View(result);*/
            return View("Scoreboard", gameElements);
        }

        public ActionResult Lore()
        {
            return View("Lore", gameElements);
        }

        public ActionResult Enemy(int? id)
        {            
            return View("Enemy", gameElements.FirstOrDefault(x => x.Id == id));
        }

        public ActionResult Play()
        {
            infoStartProcess.WorkingDirectory = Server.MapPath("~/bin");
            infoStartProcess.FileName = @"FirstGame.exe";

            Process[] lprcTestApp = Process.GetProcessesByName("FirstGame");
            if (!(lprcTestApp.Length > 0))
            {
                Process.Start(infoStartProcess);
            }
            return RedirectToAction("Briefing");
        }
    }
}