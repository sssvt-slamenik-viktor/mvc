using System;
using System.Collections.Generic;

using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Interfaces.Services.Shop;



namespace PetEShopWebMVC.Services.Shop
{



    public class ProductService : IProductService
    {



        public ICollection<Pet> GetPets()
        {
            ICollection<Pet> pets = FakePetCollection();
            return pets;
        }



        public Pet GetPet(int id)
        {
            ICollection<Pet> pets = FakePetCollection();
            Pet pet = ((List<Pet>) pets).Find(p => p.Id == id);
            return pet;
        }



        private ICollection<Pet> FakePetCollection()
        {

            ICollection<Pet> pets = new List<Pet>();

            pets.Add(GetTortoiseshell());
            pets.Add(GetCoot());
            pets.Add(GetDog());
            pets.Add(GetRabbit());
            pets.Add(GetWesternEuropeanHedgehog());
            pets.Add(GetCommonHouseMartin());
            pets.Add(GetLeastWeasel());
            pets.Add(GetMosquito());
            pets.Add(GetCommonRaccoon());
            pets.Add(GetHouseSpider());
            pets.Add(GetCommonPochard());
            pets.Add(GetCommonEel());
            pets.Add(GetEarthworm());
            pets.Add(GetEuropeanPondTurtle());

            return pets;

        }



        private static Pet GetTortoiseshell()
        {
            return new Pet(1, "babočka kopřivová", @"01_babocka_koprivova_IMG_0897.JPG", true, 10.59m, 5);
        }

        private static Pet GetCoot()
        {
            return new Pet(2, "lyska", @"02_lyska_IMG_0898.JPG", false, 3.99m, 1);
        }

        private static Pet GetDog()
        {
            return new Pet(3, "pes", @"03_pes_IMG_0900.JPG", false, 12.49m, 23);
        }

        private static Pet GetRabbit()
        {
            return new Pet(4, "králík", @"04_kralik_IMG_0901.JPG", true, 7.89m, 120);
        }

        private static Pet GetWesternEuropeanHedgehog()
        {
            return new Pet(5, "ježek západní", @"05_jezek_zapadni_IMG_0902.JPG", true, 4.69m, 0);
        }

        private static Pet GetCommonHouseMartin()
        {
            return new Pet(6, "jiřička obecná", @"06_jiricka_obecna_IMG_0903.JPG", false, 3.19m, 16);
        }

        private static Pet GetLeastWeasel()
        {
            return new Pet(7, "kolčava", @"07_kolcava_IMG_0904.JPG", true, 25.99m, 3);
        }

        private static Pet GetMosquito()
        {
            return new Pet(8, "komár písklavý", @"08_komar_pisklavy_IMG_0905.JPG", true, 2.99m, 1500);
        }

        private static Pet GetCommonRaccoon()
        {
            return new Pet(9, "mýval severní", @"09_myval_severni_IMG_0906.JPG", true, 36.99m, 1);
        }

        private static Pet GetHouseSpider()
        {
            return new Pet(10, "pokoutník domácí", @"10_pokoutnik_domaci_IMG_0907.JPG", false, 3.29m, 121);
        }

        private static Pet GetCommonPochard()
        {
            return new Pet(11, "polák velký", @"11_polak_velky_IMG_0909.JPG", true, 13.69m, 8);
        }

        private static Pet GetCommonEel()
        {
            return new Pet(12, "úhoř říční", @"12_uhor_ricni_IMG_0911.JPG", true, 41.99m, 11);
        }

        private static Pet GetEarthworm()
        {
            return new Pet(13, "žížala obecná", @"13_zizala_obecna_IMG_0912.JPG", true, 4.99m, 106);
        }

        private static Pet GetEuropeanPondTurtle()
        {
            return new Pet(14, "želva bahenní", @"14_zelva_bahenni_IMG_0913.JPG", true, 29.99m, 3);
        }



    }



}
