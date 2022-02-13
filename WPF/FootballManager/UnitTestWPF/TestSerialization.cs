using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using WPF.Model.Serialization;

namespace WPF.Model
{
    [TestClass]
    public class TestSerialization
    {
        [TestMethod]
        public void SerializeData()
        {
            List<Club> Clubs = new List<Club>
            {
                    new Club("Ліверпуль", "Ліверпуль", 1080),
                    new Club("Манчестер Юнайтед", "Манчестер", 799.85),
                    new Club("Манчестер Сіті", "Манчестер", 1080),
                    new Club("Арсенал", "Лондон", 631.95),
                    new Club("Челсі", "Лондон", 841.2),
                    new Club("Тоттенгем Готспур", "Лондон", 738.55),
                    new Club("Вест Гем Юнайтед", "Лондон", 287.95),
                    new Club("Крістал Пелес", "Лондон", 224.48),
                    new Club("Фулгем", "Лондон", 218.75),
                    new Club("Евертон", "Ліверпуль", 508.3),
                    new Club("Брайтон енд Гоув Альбіон", "Брайтон", 230.8),
                    new Club("Саутгемптон", "Саутгемптон", 219.1),
                    new Club("Бернлі", "Бернлі", 152.08),
                    new Club("Шеффілд Юнайтед", "Шеффілд", 176.05),
                    new Club("Вест-Бромвіч Альбіон", "Вест-Бромвіч", 106.55),
                    new Club("Лідс Юнайтед", "Лідс", 181.33),
                    new Club("Лестер Сіті", "Лестер", 469),
                    new Club("Ньюкасл Юнайтед", "Ньюкасл-апон-Тайн", 271.7),
                    new Club("Астон Вілла", "Бірмінгем", 311.8),
                    new Club("Вулвергемптон Вондерерз", "Вулвергемптон", 388.25)
            };

            List<Footballer> Footballers = new List<Footballer>
            {
                    new Footballer("Садіо", "Мане", Clubs[0], 10, "Сенегал", 120),
                    new Footballer("Мохаммед", "Салах", Clubs[0], 11, "Єгипет", 120),
                    new Footballer("Поль", "Погба", Clubs[1], 6, "Франція", 80),
                    new Footballer("Бруну", "Фернандеш", Clubs[1], 18, "Португалія", 80),
                    new Footballer("Маркус", "Рашфорд", Clubs[1], 10, "Англія", 80),
                    new Footballer("Рахім", "Стерлінг", Clubs[2], 7, "Англія", 128),
                    new Footballer("Кевін", "Де Брейне", Clubs[2], 17, "Бельгія", 120),
                    new Footballer("П'єр-Емерік", "Обамеянг", Clubs[3], 14, "Габон", 50),
                    new Footballer("Томас", "Парті", Clubs[3], 18, "Гана", 50),
                    new Footballer("Кай", "Гаверц", Clubs[4], 29, "Німеччина", 81),
                    new Footballer("Тімо", "Вернер", Clubs[4], 11, "Німеччина", 70),
                    new Footballer("Н'Голо", "Канте", Clubs[4], 7, "Франція", 70),
                    new Footballer("Гаррі", "Кейн", Clubs[5], 10, "Англія", 120),
                    new Footballer("Сон", "Хин Мін", Clubs[5], 7, "Південна Корея", 75),
                    new Footballer("Деклан", "Райс", Clubs[6], 41, "Англія", 55),
                    new Footballer("Себастьєн", "Алле", Clubs[6], 22, "Кот-д'Івуар", 30),
                    new Footballer("Вільфрід", "Заа", Clubs[7], 11, "Кот-д'Івуар", 50),
                    new Footballer("Еберечі", "Езе", Clubs[7], 25, "Англія", 18),
                    new Footballer("Рубен", "Лофтус-Чік", Clubs[8], 15, "Англія", 24),
                    new Footballer("Александар", "Мітрович", Clubs[8], 9, "Сербія", 22),
                    new Footballer("Рішарлісон", "де Андраде", Clubs[9], 7, "Бразилія", 60),
                    new Footballer("Домінік", "Калверт-Льюїн", Clubs[9], 9, "Англія", 40),
                    new Footballer("Льюїс", "Данк", Clubs[10], 5, "Англія", 27),
                    new Footballer("Ніл", "Мопе", Clubs[10], 9, "Франція", 22),
                    new Footballer("Денні", "Інгз", Clubs[11], 9, "Англія", 20),
                    new Footballer("Джеймс", "Ворд-Прауз", Clubs[11], 8, "Англія", 20),
                    new Footballer("Джеймс", "Тарковський", Clubs[12], 5, "Англія", 28),
                    new Footballer("Двайт", "Макніл", Clubs[12], 11, "Англія", 25),
                    new Footballer("Сандер", "Берге", Clubs[13], 8, "Норвегія", 18),
                    new Footballer("Арон", "Ремсдейл", Clubs[13], 1, "Англія", 16),
                    new Footballer("Матеус", "Перейра", Clubs[14], 12, "Бразилія", 13),
                    new Footballer("Грейді", "Діангана", Clubs[14], 11, "Англія", 12),
                    new Footballer("Родріго", "Морено", Clubs[15], 20, "Іспанія", 30),
                    new Footballer("Келвін", "Філліпс", Clubs[15], 23, "Англія", 22),
                    new Footballer("Джеймс", "Меддісон", Clubs[16], 10, "Англія", 55),
                    new Footballer("Юрі", "Тілеманс", Clubs[16], 8, "Бельгія", 45),
                    new Footballer("Вілфред", "Ндіді", Clubs[16], 25, "Нігерія", 45),
                    new Footballer("Аллан", "Сен-Максімен", Clubs[17], 10, "Франція", 32),
                    new Footballer("Каллам", "Вілсон", Clubs[17], 13, "Англія", 22.5),
                    new Footballer("Джек", "Гріліш", Clubs[18], 10, "Англія", 45),
                    new Footballer("Оллі", "Воткінс", Clubs[18], 11, "Англія", 30),
                    new Footballer("Рубен", "Невіш", Clubs[19], 8, "Португалія", 50),
                    new Footballer("Адама", "Траоре", Clubs[19], 37, "Іспанія", 40),
                    new Footballer("Рауль", "Хіменес", Clubs[19], 9, "Мексика", 40),
                    new Footballer("Рауль", "Хіменес", Clubs[19], 9, "Мексика", 40)
            };

            var Data_model = new DataModel();
            Data_model.Footballers = Footballers;
            Data_model.Clubs = Clubs;
            Serialize.SerializeData(@"D:\Юра\C#\Lab_5\Ser\SerializeData.dat", Data_model);
        }

        [TestMethod]
        public void DeserializeData()
        {
           var Data_model = Serialize.DeserializeData(@"D:\Юра\C#\Lab_5\Ser\SerializeData.dat");
        }
    }
}
