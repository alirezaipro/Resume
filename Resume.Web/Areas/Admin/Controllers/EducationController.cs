using Microsoft.AspNetCore.Mvc;
using Resume.Bussines.Services.Interface;
using Resume.DAL.ViewModels.Education;

namespace Resume.Web.Areas.Admin.Controllers;

public class EducationController : AdminBaseController
{
    #region Fields

    private readonly IEducationService _educationService;

    #endregion

    #region Constructor

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    #endregion

    #region Actions

    #region List

    public async Task<IActionResult> List(FilterEducationViewModel filter)
    {
        return View();
    }

    #endregion

    #region Create

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateEducationViewModel model)
    {
        #region Validations

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        #endregion
        
        return View();
    }

    #endregion

    #region Edit
    
    public IActionResult Edit()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditEducationViewModel model)
    {
        #region Validations

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        #endregion
        
        return View();
    }

    #endregion

    #endregion
}