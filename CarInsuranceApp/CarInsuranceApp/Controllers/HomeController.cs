using CarInsuranceApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceApp.Controllers
{
    public class HomeController : Controller
    {
        private string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Quote; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, string dateOfBirth, int carYear, string carMake, string carModel, int tickets, bool coverage, bool dui, bool age1, bool age2, bool age3, bool carAge1, bool carAge2)
        {
            

            string queryString = @"INSERT INTO Quotes (firstName, lastName, emailAddress, dateOfBirth, carYear, carMake, carModel, tickets, coverage, dui, age1, age2, age3, carAge1, carAge2) VALUES
                                   (@firstName, @lastName, @emailAddress, @dateOfBirth, @carYear, @carMake, @carModel, @tickets, @coverage, @dui, @age1, @age2, @age3, @carAge1, @carAge2)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@firstName", SqlDbType.VarChar);
                command.Parameters.Add("@lastName", SqlDbType.VarChar);
                command.Parameters.Add("@emailAddress", SqlDbType.VarChar);
                command.Parameters.Add("@dateOfBirth", SqlDbType.VarChar);
                command.Parameters.Add("@carYear", SqlDbType.Int);
                command.Parameters.Add("@carMake", SqlDbType.VarChar);
                command.Parameters.Add("@carModel", SqlDbType.VarChar);
                command.Parameters.Add("@tickets", SqlDbType.Int);
                command.Parameters.Add("@coverage", SqlDbType.VarChar);
                command.Parameters.Add("@dui", SqlDbType.Bit);
                command.Parameters.Add("@age1", SqlDbType.Bit);
                command.Parameters.Add("@age2", SqlDbType.Bit);
                command.Parameters.Add("@age3", SqlDbType.Bit);
                command.Parameters.Add("@carAge1", SqlDbType.Bit);
                command.Parameters.Add("@carAge2", SqlDbType.Bit);

                command.Parameters["@firstName"].Value = firstName;
                command.Parameters["@lastName"].Value = lastName;
                command.Parameters["@emailAddress"].Value = emailAddress;
                command.Parameters["@dateOfBirth"].Value = dateOfBirth;
                command.Parameters["@carYear"].Value = carYear;
                command.Parameters["@carMake"].Value = carMake;
                command.Parameters["@carModel"].Value = carModel;
                command.Parameters["@tickets"].Value = tickets;
                command.Parameters["@coverage"].Value = coverage;
                command.Parameters["@dui"].Value = dui;
                command.Parameters["@age1"].Value = age1;
                command.Parameters["@age2"].Value = age2;
                command.Parameters["@age3"].Value = age3;
                command.Parameters["@carAge1"].Value = carAge1;
                command.Parameters["@carAge2"].Value = carAge2;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();






            }

            double monthlyPayment = 50.00;

            if (carMake == "Porsche")
                monthlyPayment = monthlyPayment + 25;

            if (age1)
                monthlyPayment += 25;

            if (age2)
                monthlyPayment += 100;

            if (age3)
                monthlyPayment += 25;

            if (carAge1)
                monthlyPayment += 25;

            if (carAge2)
                monthlyPayment += 25;

            if (carModel == "911 Carrera")
                monthlyPayment += 25;

            monthlyPayment += tickets * 10;
            
            if (dui)
                monthlyPayment *= 1.25;

            if (coverage)
                monthlyPayment *= 1.5;
            return View(monthlyPayment);
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT firstName, lastName, emailAddress, quoteTotal from Quotes";
            List<InsuranceQuote> quotes = new List<InsuranceQuote>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var quote = new InsuranceQuote();

                    quote.firstName = reader["firstName"].ToString();
                    quote.lastName = reader["lastName"].ToString();
                    quote.emailAddress = reader["emailAddress"].ToString();
                    quote.quoteTotal = Convert.ToInt32(reader["quoteTotal"]);
                    quotes.Add(quote);
                }
                return View(quotes);
            }

            
        }
        
    }
}