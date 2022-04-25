using System;



namespace PetEShopWebMVC.BusinessObjects
{



    public class Pet
    {



        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageFile { get; set; }

        public bool IsImageLandscape { get; set; }

        public decimal Price { get; set; }

        public int PiecesOnStock { get; set; }



        public Pet(int id, string name, string imageFile, bool isImageLandscape, decimal price, int piecesOnStock)
        {
            this.Id = id;
            this.Name = name;
            this.ImageFile = imageFile;
            this.IsImageLandscape = isImageLandscape;
            this.Price = price;
            this.PiecesOnStock = piecesOnStock;
        }



        public Pet()
        {
        }



        public override string ToString()
        {
            return $"Id={this.Id}   Name={this.Name}   ImageFile={this.ImageFile}   IsImageLandscape={this.IsImageLandscape}   Price={this.Price}   PiecesOnStock={this.PiecesOnStock}";
        }



    }



}
