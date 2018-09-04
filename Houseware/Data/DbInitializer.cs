using Houseware.Data.Models;
using Houseware.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Houseware.Data
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Item.Any())
            {
                context.AddRange
                (
                    new SSItem
                    {
                        Name = "Storage Boxes & Bins, Home Store",
                        Price = 12.85M,
                        ShortDescription = "Storage Boxes & Bins, Home Stor",
                        LongDescription = " Home Sundries Use Plastic storage Boxes  ,Unit Weight(Kg) : 0.835 ,  Material  COPP ,	Plastic products,houseware,valve,artware,Mechnical quipment  ,Shape: Rectangle,Style: Classic,Material: Plastic, Place of Origin: Zhejiang,Name: Wholesale Household Objects St ,Size: 49.5x35x22.5 cm,Technics: Glossy,Capacity:20 - 35L,Load:5 - 10kg ,Plastic Type:PP,Brand Name: Young Rise,Color: Blue or Customized,Function: Custom Home Clothing Sundrie,Product:Clothing Organizer , Specification:49.5x35x22.5 cm ,Use:Clothes,Feature: Eco - Friendly,Model Number:YR - 6108,Weight:0.835 kg ,Packaging: Custom Packaging Accepted",
                        Category = Categories["Houseware Items"],
                        ImageUrl = @"~/Images/SSItems/HousewareItems/Item1.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Party Table ware",
                        Price = 42.95M,
                        ShortDescription = "Party Table ware",
                        LongDescription = "Party table ware it is good for books and many stuff like clothes and its size is suitable for all rooms ",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item2.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Drawer Chest - Grey & Pine ",
                        Price = 112.95M,
                        ShortDescription = "Drawer Chest - Grey & Pine",
                        LongDescription = "The Nordic 6+6 drawer chest comes with solid pine top and handles. Each drawer opens smoothly on metal runners and the 2-tone finish gives it a country style feel.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item3.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Eauford Double Bed Frame - Grey",
                        Price = 146.75M,
                        ShortDescription = "Eauford Double Bed Frame - Grey",
                        LongDescription = "How's this for the ultimate in relaxation? The Beauford double bed is luxuriously upholstered in a cool grey, soft-to-the-touch, wool-effect fabric. Its high-back sweeping curved headboard will cocoon you as you sleep – bliss! We've really paid attention to every detail and finished the Beauford with a feature curved footboard and elegant turned wooden feet.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item4.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = " Amelie Dressing Table, Mirror and Stool - White",
                        Price = 217.95M,
                        ShortDescription = " Amelie Dressing Table, Mirror and Stool - White",
                        Category = Categories["Houseware Items"],
                        LongDescription = "This is one bedroom furniture collection to swoon over. The Provence styled white Amelie dressing table brings a touch of elegance to your home. We've included a mirror and stool, so it's everything you need when you're fixing your hair and makeup for the day. The Amelie stands out from the rest with its stainless-steel handles and curvaceous details.",
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item5.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Men's Health Utility Bench ",
                        Price = 115.95M,
                        ShortDescription = "Men's Health Utility Bench ",
                        LongDescription = "Get a full weight-training workout at home with this Utility Bench. This all-purpose gym includes a 7 - position back pad that adjusts for chest, incline, military and decline press positions. There is a 3-position tilting seat pad with high-density, boxed 2-tone upholstery that is constructed from top-grade high-density foam.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item6.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Ripple Console Storage Cabinet - White",
                        Price = 60.95M,
                        ShortDescription = "Ripple Console Storage Cabinet - White",
                        LongDescription = "The Ripple bathroom unit brings a modern look to your room. Finished in a cool white, the wavy textured front gives this collection a fitting water-inspired finish. This unit includes a slim cupboard to keep personal things out of sight, then there's open shelving on the side for everyday toiletries.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item7.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Slow Close Bin & Toilet Brush Set - Ink Blue",
                        Price = 15.95M,
                        ShortDescription = "Slow Close Bin & Toilet Brush Set - Ink Blue",
                        LongDescription = "This bin and brush set is perfect for creating a coordinated look in your bathroom. The pedal bin features a slow-close lid and a lift-out inner section for easy emptying. The brush-holder comes complete with a long handle – perfect for storing an extra loo roll.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item8.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "6 Piece Wooden Bathroom Accessory Set - White ",
                        Price = 135.95M,
                        ShortDescription = "6 Piece Wooden Bathroom Accessory Set - White",
                        LongDescription = "Add the last finishing touches to your bathroom with this traditional 6-piece set in a contemporary white wood. This set includes everything you need to keep your bathroom necessities close to hand. These matching accessories help tie up the overall look in a contemporary bathroom.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item9.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "3 Tier Bathroom Shelves - White",
                        Price = 115.95M,
                        ShortDescription = "3 Tier Bathroom Shelves - White ",
                        LongDescription = "From soaps and shampoos to lotions and potions, the bathroom can soon become messy with all our various scrubbing and grooming products. Step up the Sainsbury's Home 3-tiered bathroom shelves, in a oh-so-modern ladder design. You can keep your tub sides clear of clutter, hooray! And the fact its tiered gives you that bit of extra vertical storage space.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item10.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Mirrored Bathroom Cabinet with Shelves - White",
                        Price = 50.95M,
                        ShortDescription = "Mirrored Bathroom Cabinet with Shelves - White",
                        LongDescription = "This contemporary bathroom cabinet with mirror door offers plenty of storage space for bathroom essentials. Made of wood effect it has 5 shelves and sports a beautiful design that will instantly upgrade the look of your bathroom.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item11.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Illuminated Bathroom Mirror - White Gloss",
                        Price = 15.95M,
                        ShortDescription = "Illuminated Bathroom Mirror - White Gloss",
                        LongDescription = "An ultra modern and stylish LED mirror light with a flat and sleek design suitable for modern day bathrooms. The mirror is battery operated and features 12 lights for optimum brightness.Mirrored glass and steel with a white gloss painted finish.Suitable for zone 2 and outside zones.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item12.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Wooden Corner Bathroom Cabinet - White",
                        Price = 125.95M,
                        ShortDescription = "Wooden Corner Bathroom Cabinet - White",
                        LongDescription = "The clean white finish and modern design make this wooden bathroom corner cabinet perfect for the contemporary home. Ideal for storing all your cosmetics and bathroom accessories. Includes one adjustable shelf to help you fit those awkward bottles in.",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item13.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Hygena Lido Glass Bar Table and 2 Chairs - Black",
                        Price = 174.95M,
                        ShortDescription = "Hygena Lido Glass Bar Table and 2 Chairs - Black",
                        LongDescription = "Don't fork out a fortune – let us introduce you to our great value Hygena Lido bar table set. It comes with a toughened glass top that sits on top of a coordinated painted frame. Sleek metal discs hold the glass securely in place, for a robust and contemporary finish. The 2 bar stools feature comfy padded seats and long sleek backrests; bringing a relaxed vibe to laid-back breakfasts and casual suppers. This contemporary set can be taken home today - so you could be eating your dinner off it tonight!",
                        Category = Categories["Houseware Items"],
                        ImageUrl = "~/Images/SSItems/HousewareItems/Item14.jpg",
                        InStock = false,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Men's Health Utility Bench",
                        Price = 132.95M,
                        ShortDescription = "Men's Health Utility Bench",
                        LongDescription = "Get a full weight-training workout at home with this Utility Bench. This all-purpose gym includes a 7 - position back pad that adjusts for chest, incline, military and decline press positions. There is a 3-position tilting seat pad with high-density, boxed 2-tone upholstery that is constructed from top-grade high-density foam.",
                        Category = Categories["Sports Items"],
                        ImageUrl = "~/Images/SSItems/SportsItems/Item1.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Reebok Jet 100 Series Cross Trainer",
                        Price = 182.95M,
                        ShortDescription = "Reebok Jet 100 Series Cross Trainer",
                        LongDescription = "The Reebok Jet 100 Series Cross Trainer operates from a large 9kg flywheel which results in a smooth and quiet motion. Ideal for lower impact workouts, the elliptical keeps you challenged with 32 levels of resistance and 19 programs which are easily controlled through the sleek 5 inch backlit LCD display. With floor level adjustment the cross trainer remains sturdy on any indoor surface.",
                        Category = Categories["Sports Items"],
                        ImageUrl = "~/Images/SSItems/SportsItems/Item2.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Challenge Rechargeable Engine Starter",
                        Price = 112.95M,
                        ShortDescription = "Challenge Rechargeable Engine Starter",
                        LongDescription = "This rechargeable Challenge Engine Starter is great for emergency situations. The red LED indicates the charging status whilst the work light provides added convenience. The battery status is shown on the analogue gauge. Heavy duty booster cables, sealed lead acid battery. Dimensions: L36.5 x W11.5 x D37cm, weight 5.6Kg.",
                        Category = Categories["Sports Items"],
                        ImageUrl = "~/Images/SSItems/SportsItems/Item3.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Everlast Sit Up Bench",
                        Price = 182.95M,
                        ShortDescription = "Everlast Sit Up Bench",
                        LongDescription = "This Everlast sit up bench will help you to develop stronger abdominal muscles. The high density support foam in the padded backrest gives you comfort and support while you workout. You can adjust the incline height for an even more intense exercise as you progress. When not in use, this bench will conveniently fold up flat for easy storage.",
                        Category = Categories["Sports Items"],
                        ImageUrl = @".\Images\SSItems\SportsItems\Item4.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    },
                    new SSItem
                    {
                        Name = "Opti Multi Use Workout Bench",
                        Price = 192.95M,
                        ShortDescription = "Opti Multi Use Workout Bench",
                        LongDescription = "This adjustable workout bench from Opti allows you to target a range of different muscle groups. Perform bench and shoulder presses, leg extensions and more in the comfort of your own home, in order to tone, shape and define your muscles.",
                        Category = Categories["Sports Items"],
                        ImageUrl = @".\Images\SSItems\SportsItems\Item5.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = ""
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Houseware Items", Description="All Houseware Items" },
                        new Category { CategoryName = "Sports Items", Description="All Sports Items" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
