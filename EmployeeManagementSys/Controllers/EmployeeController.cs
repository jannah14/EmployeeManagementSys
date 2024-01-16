using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSys.DTOs;
using EmployeeManagementSys.Services;

namespace EmployeeManagementSys.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _employeeService.GetEmployees();

            if (employees != null)
            {
                return View(employees);
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Details(string id)
        {
            var employee = await _employeeService.GetEmployeeById(id);

            if (employee != null)
            {
                return View(employee);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeDTO employeeDTO)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.CreateEmployee(employeeDTO);
                return RedirectToAction(nameof(Index));
            }

            return View(employeeDTO);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var employee = await _employeeService.GetEmployeeById(id);

            if (employee != null)
            {
                return View(employee);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, EmployeeDTO employeeDTO)
        {
            if (id != employeeDTO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _employeeService.UpdateEmployee(employeeDTO);
                return RedirectToAction(nameof(Index));
            }

            return View(employeeDTO);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var employee = await _employeeService.GetEmployeeById(id);

            if (employee != null)
            {
                return View(employee);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _employeeService.DeleteEmployee(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
