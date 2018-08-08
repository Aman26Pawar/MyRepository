using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemo1;

namespace MVCDemo1.Controllers
{
    public class EmployeeDatasController : Controller
    {
        private EmployeeInfoDemoEntities db = new EmployeeInfoDemoEntities();

        // GET: EmployeeDatas
        public ActionResult Index()
        {
            var employeeDatas = db.EmployeeDatas.Include(e => e.EmployeeType);
            return View(employeeDatas.ToList());
        }

        // GET: EmployeeDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeData employeeData = db.EmployeeDatas.Find(id);
            if (employeeData == null)
            {
                return HttpNotFound();
            }
            return View(employeeData);
        }

        // GET: EmployeeDatas/Create
        public ActionResult Create()
        {
            ViewBag.EmpType = new SelectList(db.EmployeeTypes, "TypeID", "EmpType");
            return View();
        }

        // POST: EmployeeDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpID,EmpName,Department,EmpType,HourlySal,Bonusrate")] EmployeeData employeeData)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDatas.Add(employeeData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpType = new SelectList(db.EmployeeTypes, "TypeID", "EmpType", employeeData.EmpType);
            return View(employeeData);
        }

        // GET: EmployeeDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeData employeeData = db.EmployeeDatas.Find(id);
            if (employeeData == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpType = new SelectList(db.EmployeeTypes, "TypeID", "EmpType", employeeData.EmpType);
            return View(employeeData);
        }

        // POST: EmployeeDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpID,EmpName,Department,EmpType,HourlySal,Bonusrate")] EmployeeData employeeData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpType = new SelectList(db.EmployeeTypes, "TypeID", "EmpType", employeeData.EmpType);
            return View(employeeData);
        }

        // GET: EmployeeDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeData employeeData = db.EmployeeDatas.Find(id);
            if (employeeData == null)
            {
                return HttpNotFound();
            }
            return View(employeeData);
        }

        // POST: EmployeeDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeData employeeData = db.EmployeeDatas.Find(id);
            db.EmployeeDatas.Remove(employeeData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
