using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace BD_2._0
{
    public class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int yos { get; set; }
        public string sale { get; set; }
        public int salevalue { get; set; }
        public int count { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
    public class Event
    {
        public int Id { get; set; }
        public string ename { get; set; }
        public string etime { get; set; }
        public double eprice { get; set; }
        public string elocationname { get; set; }
        public string eaddress { get; set; }
        public int ticketsquantity { get; set; }
    }
    public class Theatre:Event { }
    public class Museum:Event { }
    public class Expo:Event { }
    class Program
    {
        static void Main(string[] args)
        {
      
            using (BD_2 database = new BD_2())
            {
                var Abay = new Theatre()
                {
                    elocationname = "Театр Оперы и Балета им.Абая",
                    eaddress = "ул.Кабанбай батыра,110"
                };
                var Lermontov = new Theatre()
                {
                    elocationname = "Театр им.Лермонтова",
                    eaddress = "проспект Абая, 43"
                };
                var Auezov = new Theatre()
                {
                    elocationname = "Театр им.Ауэзова",
                    eaddress = "проспект Абая,103"
                };
                var Musrepov = new Theatre()
                {
                    elocationname = "ТЮЗ им.Мусрепова",
                    eaddress = "проспект Абылай хана,38"
                };
                 
                var ArtmekenG = new Expo()
                {
                    elocationname = "Artmeken Gallery",
                    eaddress = "Проспект Назарбаева,149"
                };
                var EsentayG = new Expo()
                {
                    elocationname = "Esentai Gallery",
                    eaddress = "Проспект Аль-Фараби, 77/8"
                };
                var VernisazhG = new Expo()
                {
                    elocationname = "Галлерея \"Вернисаж\"",
                    eaddress = "Проспект Достык,17"
                };
                var KasteevE = new Expo()
                {
                    elocationname = "Музей им.Кастеева",
                    eaddress = "Микрорайон Коктем-3,22/1"
                };
              
                var Geology = new Museum()
                {
                    elocationname = "Музей геологии",
                    eaddress = "Проспект Достык,85"
                };
                var KasteevM = new Museum()
                {
                    elocationname = "Музей им.Кастеева",
                    eaddress = "Микрорайон Коктем-3,22/1"
                };
                var MusicalInstrument = new Museum()
                {
                    elocationname = "Музей музыкальных инструментов",
                    eaddress = "ул. Зенкова,24а"
                };
                var KunaevHouse = new Museum()
                {
                    elocationname = "Музей им.Кунаева",
                    eaddress = "ул.Тулебаева,117"
                };
                
                 var e1 = new List<Event>()
                 {
                    new Theatre(){ename="Опера \"Искатели жемчуга\"",eprice=2000,ticketsquantity=200,elocationname=Abay.elocationname,eaddress=Abay.eaddress},
                    new Theatre(){ename="Балет\"Лебединое озеро\"",eprice=1700,ticketsquantity=200,elocationname=Abay.elocationname,eaddress=Abay.eaddress},
                    new Theatre(){ename="Пьеса\"Ищите женщину\"",eprice=2200,ticketsquantity=200,elocationname=Lermontov.elocationname,eaddress=Lermontov .eaddress},
                    new Theatre(){ename="Пьеса\"Ужин с дураком\"",eprice=2000,ticketsquantity=200,elocationname=Lermontov.elocationname,eaddress=Lermontov.eaddress},
                    new Theatre(){ename="Пьеса\"Песок надежд\"",eprice=1900,ticketsquantity=200,elocationname=Auezov.elocationname,eaddress=Auezov.eaddress},
                    new Theatre(){ename="Пьеса\"Чаша любви\"",eprice=1700,ticketsquantity=200,elocationname=Auezov.elocationname,eaddress=Auezov.eaddress},
                    new Theatre(){ename="Пьеса\"Красавица и Чудовище\"",eprice=1750,ticketsquantity=200,elocationname=Musrepov.elocationname,eaddress=Musrepov.eaddress},
                    new Theatre(){ename="Пьеса\"Дюймовочка\"",eprice=1700,ticketsquantity=200,elocationname=Musrepov.elocationname,eaddress=Musrepov.eaddress},
                    new Expo(){ename="Выставка живописи Эдварда Мане",eprice=2000,ticketsquantity=200,elocationname=ArtmekenG.elocationname,eaddress=ArtmekenG.eaddress},
                    new Expo(){ename="Выставка портретов Абылхана Кастеева",eprice=1800,ticketsquantity=200,elocationname=EsentayG.elocationname,eaddress=EsentayG.eaddress},
                    new Expo(){ename="Выставка современного искусства \"Новый мир\"",eprice=1500,ticketsquantity=200,elocationname=VernisazhG.elocationname,eaddress=VernisazhG.eaddress},
                    new Expo(){ename="Выставка футуристических картин \"Футурист\"",eprice=1800,ticketsquantity=200,elocationname=KasteevE.elocationname,eaddress=KasteevE.eaddress},
                    new Museum(){ename="Выставка редких пород полезных ископаемых",eprice=1800,ticketsquantity=200,elocationname=Geology.elocationname,eaddress=Geology.eaddress},
                    new Museum(){ename="Выставка портретов Абылхана Кастеева",eprice=1500,ticketsquantity=200,elocationname=KasteevM.elocationname,eaddress=KasteevM.eaddress},
                    new Museum(){ename="Выставка музыкальных инструментов народов востока",eprice=1750,ticketsquantity=200,elocationname=MusicalInstrument.elocationname,eaddress=MusicalInstrument.eaddress},
                    new Museum(){ename="Дом-музей им.Кунаева",eprice=2000,ticketsquantity=200,elocationname=KunaevHouse.elocationname,eaddress=KunaevHouse.eaddress}
                 };
                /*database.evs.AddRange(e1);
                database.SaveChanges();*/
                for (int i = 0; ; i++)
                {
                    Console.WriteLine("Выберите раздел:\n1.Регистрация\n2.Вход в аккаунт");
                    int t = int.Parse(Console.ReadLine());
                    if (t == 1)
                    {
                        Console.WriteLine("Добро пожаловать в Регистрацию!");
                        Console.Write("Введите ваш email: ");
                        string email = Console.ReadLine();
                        while (email.EndsWith("@mail.ru") == false || (email.EndsWith("@gmail.com") == false) || (email.EndsWith("@yandex.ru")) == false)
                        {
                            if (email.EndsWith("@mail.ru") == true || (email.EndsWith("@gmail.com") == true) || (email.EndsWith("@yandex.ru")) == true)
                            {
                                Console.WriteLine("Ваш e-mail адрес:" + email);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Неверный e-mail, повторите ввод: ");
                                email = Console.ReadLine();
                            }
                        }
                        Console.Write("Введите ваше имя: ");
                        string imya = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Введите вашу фамилию: ");
                        string fam = Console.ReadLine();
                        Console.Write("Год обучения: ");
                        int god = int.Parse(Console.ReadLine());
                        Console.Write("Придумайте логин: ");
                        string log = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Придумайте пароль: ");
                        string pass = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Введите пароль ещё раз, для подтверждения: ");
                    l1:
                        string pass1 = Console.ReadLine();
                        while (pass1 != pass)
                        {
                            Console.WriteLine("Пароли не совпадают, повторите ввод: ");
                            goto l1;
                        }
                        MailAddress from = new MailAddress("avataraang16@mail.ru", "Sergey");
                        MailAddress to = new MailAddress($"{email}");
                        MailMessage m = new MailMessage(from, to);
                        m.Subject = ("Регистрация");
                        m.Body = $"<em>{fam} {imya}, регистрация завершена успешно!</em>\nВаш логин: {log}\nВаш пароль: {pass}";
                        m.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                        smtp.Credentials = new NetworkCredential("avataraang16@mail.ru", "Semykin01");
                        smtp.EnableSsl = true;
                        smtp.Send(m);
                        Console.WriteLine("Сообщение о регистрации отправлено на почту");
                        Student s = new Student { name = imya, surname = fam, yos = god, login = log, password = pass };
                        Console.WriteLine("Аккаунт зарегистрирован!");
                        Console.WriteLine("Нажмите любую кнопку для выхода в Главное Меню ...");
                        database.sts.Add(s);
                        database.SaveChanges();
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (t == 2)
                    {
                        
                          Console.WriteLine("Вход в аккаунт");
                        metka1:
                           Console.Write("Введите логин: ");
                           string log1 = Console.ReadLine();
                           Console.WriteLine();
                           Console.Write("Введите пароль: ");
                           string pass2 = Console.ReadLine();
                           Console.WriteLine();
                        foreach (Student st in database.sts)
                        {
                            while (log1 == st.login && pass2 == st.password)
                            {
                                if (log1 == st.login && pass2 == st.password)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Ваш АйДи: {st.ID}\nИмя: {st.name}\nФамилия: {st.surname}\n Год обучения: {st.yos}");
                                    Console.WriteLine("Выберите раздел:\n1.Регистрация\n2.Вход в аккаунт");
                                    Console.ReadLine();
                                }
                            }
                             
                               
                            


                            
                        }
                    }
                }
            
            }
        }
    }
}
