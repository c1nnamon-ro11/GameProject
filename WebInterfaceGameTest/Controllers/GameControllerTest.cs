using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebInterfaceGame.Controllers;
using System.Web.Mvc;

namespace WebInterfaceGame.Controllers
{
    [TestClass]
    public class GameControllerTest
    {

        //Briefing
        [TestMethod]
        public void BriefingViewResultNotNull()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Briefing() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BriefingViewEqualindexBulCshtml()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Briefing() as ViewResult;
            Assert.AreEqual("Briefing", result.ViewName);
        }

        //Rules
        [TestMethod]
        public void RulesViewResultNotNull()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Rules() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RulesViewEqualindexBulCshtml()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Rules() as ViewResult;
            Assert.AreEqual("Rules", result.ViewName);
        }

        //Lore
        [TestMethod]
        public void LoreViewResultNotNull()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Lore() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoreViewEqualindexBulCshtml()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Lore() as ViewResult;
            Assert.AreEqual("Lore", result.ViewName);
        }

        //Enemy
        [TestMethod]
        public void EnemyViewResultNotNull()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Enemy(null) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EnemyViewEqualindexBulCshtml()
        {
            GameController controller = new GameController();
            ViewResult result = controller.Enemy(2) as ViewResult;
            Assert.AreSame("Enemy", result.ViewName);
        }
    }
}
