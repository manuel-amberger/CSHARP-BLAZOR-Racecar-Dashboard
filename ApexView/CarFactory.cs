namespace ApexView;

public static class CarFactory {
    public static List<Car> CarList { get; set; } = new(){
        new Car() { 
            Position = 1,
            Driver = new Driver { Name = "Thomas Preining", Age = 27 }, 
            Team = new Team { Name = "Manthey EMA" }, 
            ImgUrl = "ThomasPreining.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 2,
            Driver = new Driver { Name = "Bastian Buus", Age = 22 }, 
            Team = new Team { Name = "Manthey EMA" }, 
            ImgUrl = "BastianBuus.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 3,
            Driver = new Driver { Name = "Ben Dörr", Age = 19 }, 
            Team = new Team { Name = "Dörr Motorsport" }, 
            ImgUrl = "BenDoerr.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 4,
            Driver = new Driver { Name = "Finn Wiebelhaus", Age = 19 }, 
            Team = new Team { Name = "Haupt Racing Team" }, 
            ImgUrl = "FinnWiebelhaus.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 5,
            Driver = new Driver { Name = "Jules Gounon", Age = 31 }, 
            Team = new Team { Name = "Haupt Racing Team" }, 
            ImgUrl = "JulesGounon.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 6,
            Driver = new Driver { Name = "Kelvin van der Linde", Age = 29 }, 
            Team = new Team { Name = "Abt Sportsline" }, 
            ImgUrl = "KelvenVanDerLinde.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 7,
            Driver = new Driver { Name = "Luca Engstler", Age = 26 }, 
            Team = new Team { Name = "GRT Grasser Racing Team" }, 
            ImgUrl = "LucaEngstler.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 8,
            Driver = new Driver { Name = "Lucas Auer", Age = 31 }, 
            Team = new Team { Name = "Winward Racing" }, 
            ImgUrl = "LucasAuer.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 9,
            Driver = new Driver { Name = "Maro Engel", Age = 40 }, 
            Team = new Team { Name = "Winward Racing" }, 
            ImgUrl = "MarcoEngel.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 10,
            Driver = new Driver { Name = "Marco Mapelli", Age = 38 }, 
            Team = new Team { Name = "GRT Grasser Racing Team" }, 
            ImgUrl = "MarcoMapelli.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 11,
            Driver = new Driver { Name = "Marco Wittmann", Age = 36 }, 
            Team = new Team { Name = "Schubert Motorsport" }, 
            ImgUrl = "MarcoWittmann.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 12,
            Driver = new Driver { Name = "Maximilian Paul", Age = 26 }, 
            Team = new Team { Name = "Paul Motorsport" }, 
            ImgUrl = "MaximilianPaul.jpeg",
            CarData = new CarData() 
        },
        new Car() { 
            Position = 13,
            Driver = new Driver { Name = "Mirko Bortolotti", Age = 36 }, 
            Team = new Team { Name = "SSR Performance" }, 
            ImgUrl = "MircoBortolotti.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 14,
            Driver = new Driver { Name = "Nicki Thiim", Age = 37 }, 
            Team = new Team { Name = "SSR Performance" }, 
            ImgUrl = "NickiTiim.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 15,
            Driver = new Driver { Name = "Nicolas Baert", Age = 24 }, 
            Team = new Team { Name = "Comtoyou Racing" }, 
            ImgUrl = "NicolasBaert.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 16,
            Driver = new Driver { Name = "Ricardo Feller", Age = 25 }, 
            Team = new Team { Name = "Abt Sportsline" }, 
            ImgUrl = "Ricardofeller.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 17,
            Driver = new Driver { Name = "Thierry Vermeulen", Age = 23 }, 
            Team = new Team { Name = "Emil Frey Racing" }, 
            ImgUrl = "ThierryVermeulen.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 18,
            Driver = new Driver { Name = "Arjun Maini", Age = 28 }, 
            Team = new Team { Name = "Haupt Racing Team" }, 
            ImgUrl = "ArjunMaini.jpg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 19,
            Driver = new Driver { Name = "Timo Glock", Age = 44 }, 
            Team = new Team { Name = "BMW M Motorsport" }, 
            ImgUrl = "TimoGlock.jpeg", 
            CarData = new CarData() 
        },
        new Car() { 
            Position = 20,
            Driver = new Driver { Name = "Tom Kalender", Age = 18 }, 
            Team = new Team { Name = "Land-Motorsport" }, 
            ImgUrl = "TomKalender.jpeg", 
            CarData = new CarData() 
        }
    };
}