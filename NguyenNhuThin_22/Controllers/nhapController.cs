/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenNhuThin_22.Controllers
{
    public class nhapController : Controller
    {
        // GET: nhap
        public ActionResult Index()
        {
            return View();
        }
    }
}
// GET: NhaCungCap/Create
[Authorize]
public ActionResult Create()
{
    ViewBag.NhaCungCap = db.NhaCungCaps;
    return View();
}

[HttpPost, ValidateInput(false)]
[ValidateAntiForgeryToken]
public ActionResult Create([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap nhaCungCap)
{
    if (ModelState.IsValid)
    {
        db.NhaCungCaps.Add(nhaCungCap);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    return View(hangHoa);
}

// GET: HangHoa/Edit/5
public ActionResult Edit(string id)
{
    if (id == null)
    {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    }
    NhaCungCap nhaCungCap = db.NhaCungCaps.Find(id);
    if (nhaCungCap == null)
    {
        return HttpNotFound();
    }
    return View(nhaCungCap);
}

// POST: HangHoa/Edit/5
// To protect from overposting attacks, enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Edit([Bind(Include = "MaHangHoa,TenHH,DonGia,DonViTinh,MaNCC")] HangHoa hangHoa)
{
    if (ModelState.IsValid)
    {
        db.Entry(hangHoa).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(hangHoa);
}

// GET: NhaCungCap/Delete/5
public ActionResult Delete(string id)
{
    if (id == null)
    {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
    }
    NhaCungCap nhaCungCap = db.NhaCungCaps.Find(id);
    if (nhaCungCap == null)
    {
        return HttpNotFound();
    }
    return View(nhaCungCap);
}

// POST: HangHoa/Delete/5
[HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public ActionResult DeleteConfirmed(string id)
{
    HangHoa hangHoa = db.HangHoas.Find(id);
    db.HangHoas.Remove(hangHoa);
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
}*/