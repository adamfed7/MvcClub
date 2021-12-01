using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcClub.Data;
using System;
using System.Linq;

namespace MvcClub.Models
{
    public class SendData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcClubContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcClubContext>>()))
            {
                if (context.Player.Any())
                {
                    return; 
                }

                context.Player.AddRange(
                    new Player
                    {
                        Player_number = 11,
                        First_name = "Marco",
                        Surname = "Reus",
                        Position = "Ofensywny pomocnik",
                        Matches = 12,
                        Yellow_cards = 2,
                        Red_cards = 0,
                        Goal = 4,
                        Assist = 8
                    },

                    new Player
                    {
                        Player_number = 9,
                        First_name = "Erling",
                        Surname = "Haaland",
                        Position = "Środkowy napastnik",
                        Matches = 7,
                        Yellow_cards = 2,
                        Red_cards = 0,
                        Goal = 10,
                        Assist = 8
                    },

                    new Player
                    {
                        Player_number = 15,
                        First_name = "Mats",
                        Surname = "Hummels",
                        Position = "Środkowy obrońca",
                        Matches = 11,
                        Yellow_cards = 1,
                        Red_cards = 0,
                        Goal = 1,
                        Assist = 1
                    },

                    new Player
                    {
                        Player_number = 22,
                        First_name = "Jude",
                        Surname = "Bellingham",
                        Position = "Środkowy pomocnik",
                        Matches = 12,
                        Yellow_cards = 3,
                        Red_cards = 0,
                        Goal = 2,
                        Assist = 3
                    },

                    new Player
                    {
                        Player_number = 23,
                        First_name = "Emre",
                        Surname = "Can",
                        Position = "Defensywny pomocnik",
                        Matches = 6,
                        Yellow_cards = 0,
                        Red_cards = 0,
                        Goal = 2,
                        Assist = 0
                    },

                    new Player
                    {
                        Player_number = 19,
                        First_name = "Julian",
                        Surname = "Brandt",
                        Position = "Ofensywny pomocnik",
                        Matches = 10,
                        Yellow_cards = 0,
                        Red_cards = 0,
                        Goal = 2,
                        Assist = 2
                    },

                    new Player
                    {
                        Player_number = 28,
                        First_name = "Axel",
                        Surname = "Witsel",
                        Position = "Defensywny pomocnik",
                        Matches = 13,
                        Yellow_cards = 2,
                        Red_cards = 0,
                        Goal = 0,
                        Assist = 0
                    },

                    new Player
                    {
                        Player_number = 24,
                        First_name = "Thomas",
                        Surname = "Meunier",
                        Position = "Prawy obrońca",
                        Matches = 10,
                        Yellow_cards = 4,
                        Red_cards = 0,
                        Goal = 0,
                        Assist = 3
                    },

                    new Player
                    {
                        Player_number = 13,
                        First_name = "Raphael",
                        Surname = "Guerreiro",
                        Position = "Lewy obrońca",
                        Matches = 7,
                        Yellow_cards = 1,
                        Red_cards = 0,
                        Goal = 3,
                        Assist = 1
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
