using System;

namespace _1

{

    public class Address

    {

        private int index;

        private string country;

        private string city;

        private string house;

        private string apartament;

        public int Index

        {

            get

            {

                return index;

            }

            set

            {

                index = value;

            }

        }

        public string Country

        {

            get

            {

                return country;

            }

            set

            {

                country = value;

            }

        }

        public string City

        {

            get

            {

                return city;

            }

            set

            {

                city = value;

            }

        }

        public string House

        {

            get

            {

                return house;

            }

            set

            {

                house = value;

            }

        }

        public string Apartament

        {

            get

            {

                return apartament;

            }

            set

            {

                apartament = value;

            }

        }

        public Address(int index, string country, string city, string house, string apartament)

        {

            this.index = index;

            this.country = country;

            this.city = city;

            this.house = house;

            this.apartament = apartament;

        }

        public void About()

        {

            Console.WriteLine($"Index: {this.index}\nCountry: {this.country}\nCity: {this.city}\nHouse: {this.house}\nApartament: {this.apartament}");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Address NewAddress = new Address(29000, "Ukraine", "Kiev", "1", "2");

            NewAddress.City = "Khmelnytskyi";

            NewAddress.About();

            Console.ReadKey();

        }
    }
}