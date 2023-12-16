using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using ClosedXML.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using X.PagedList;

namespace GymApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BranchController : Controller
    {
        private IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }
        public IActionResult Index(int page = 1)
        {
            var branches = _branchService.GetAll().ToPagedList(page, 3);
            return View(branches);
        }
        
        public IActionResult AddBranch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBranch(Branch branch)
        {

            BranchValidator b = new BranchValidator();
            var results = b.Validate(branch);
            if (results.IsValid)
            {
                _branchService.Add(branch);
            }
            else
            {
                foreach (var err in results.Errors)
                {
                    ModelState.AddModelError(err.PropertyName, err.ErrorMessage);
                }

                return View();
            }

            return RedirectToAction("Index");


        }

        public IActionResult EditBranch(int branchId)
        {
            var branch = _branchService.GetById(branchId);
            if(branch != null)
            {
                return View(branch);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult EditBranch(Branch branch)
        {
            if (ModelState.IsValid)
            {
                _branchService.Update(branch);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult DeleteBranch(int branchId)
        {
            var branch = _branchService.GetById(branchId);
            _branchService.Delete(branch);

            return RedirectToAction("Index");
        }

        public IActionResult ExportDynamicExcelBranchList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                var entityType = _branchService.GetType();

                int rowNum = 1;

                worksheet.Cell(rowNum, 1).Value = "BranchName";
                worksheet.Cell(rowNum, 2).Value = "BranchInfo";
                worksheet.Cell(rowNum, 3).Value = "BranchPrice";

                foreach (var branch in _branchService.GetAll())
                {
                    rowNum++;

                    worksheet.Cell(rowNum, 1).Value = branch.BranchName;
                    worksheet.Cell(rowNum, 2).Value = branch.BranchInfo;
                    worksheet.Cell(rowNum, 3).Value = branch.BranchPrice;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BranchList.xlsx");
                }
            }
        }
    }
}
