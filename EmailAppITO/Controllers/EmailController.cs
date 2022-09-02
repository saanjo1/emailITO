using AutoMapper;
using Data.Entities;
using EmailAppITO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Vereyon.Web;

namespace EmailAppITO.Controllers
{
    public class EmailController : Controller
    {
        private readonly MyDbContext _databaseContext;
        private readonly IMapper _mapper;
        public readonly IFlashMessage _flashMessage;

        public EmailController(MyDbContext databaseContext, IMapper mapper, IFlashMessage flashMessage)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
            _flashMessage = flashMessage;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [ActionName("send_emails")]
        public IActionResult SendEmail()
        {
            var viewModel = new EmailManageViewModel();

            return PartialView("Modal", viewModel);

        }

        [HttpPost]
        [ActionName("send_emails")]
        public IActionResult SendEmail(EmailManageViewModel viewModel)
        {
            Email email = new Email()
            {

            };
            _databaseContext.Add(email);
            try
            {
                _mapper.Map(viewModel, email);
                _databaseContext.SaveChanges();
                _flashMessage.Confirmation("Email sent successfully.");

            }
            catch (Exception)
            {
                _flashMessage.Danger("An error occured while sending an email. Please check your inputs and try again.");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult History()
        {
            var emails = _databaseContext.Emails.ToList();

            return View(new EmailIndexViewModel
            {
                Emails = emails
            });
        }
    }
}
