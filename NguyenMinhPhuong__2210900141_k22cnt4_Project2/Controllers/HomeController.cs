using NguyenMinhPhuong__2210900141_k22cnt4_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace NguyenMinhPhuong__2210900141_k22cnt4_Project2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NmpIndex()
        {
            return View();
        }

        public ActionResult NmpAbout()
        {
           

            return View();
        }

        public ActionResult NmpContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NmpContact(Contact model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.To.Add("van.convet@gmail.com"); // Địa chỉ email nhận
                    mail.From = new MailAddress("nminhphuong685@gmail.com"); // Địa chỉ email của bạn
                    mail.Subject = "Liên hệ từ " + model.Name;
                    mail.Body = $"Tên: {model.Name}\nEmail: {model.Email}\nTin nhắn: {model.Message}";

                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com", // Địa chỉ máy chủ SMTP
                        Port = 587, // Cổng SMTP
                        Credentials = new System.Net.NetworkCredential("nminhphuong685@gmail.com", "Phuong@2004"),
                        EnableSsl = true
                    };

                    smtp.Send(mail);
                    ViewBag.Message = "Cảm ơn bạn! Tin nhắn của bạn đã được gửi.";
                }
                catch (SmtpException smtpEx)
                {
                    ViewBag.Message = "Có lỗi xảy ra khi gửi email: " + smtpEx.Message;
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Có lỗi xảy ra: " + ex.Message;
                }
            }
            else
            {
                ViewBag.Message = "Vui lòng điền tất cả thông tin cần thiết.";
            }

            return View(model);
        }
    }
}