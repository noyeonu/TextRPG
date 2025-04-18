using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp5
{
    internal class Program
    {
        public static int Ap;
        public static int Hp;
        public static int Def;
        public static int Gold;
        public static int Lv = 1;

        static void Statistics(int power, int def, int hp, int gold)
        {
            Ap += power;
            Hp += hp;
            Def += def;
            Gold += gold;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                bool nameConfirmed = false;

                string platerName = "";

                while (!nameConfirmed)
                {
                    Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
                    Console.WriteLine("원하시는 이름을 설정해주세요.");
                    string playerName = Console.ReadLine();

                    if (string.IsNullOrEmpty(playerName))
                    {
                        Console.WriteLine("이름은 비워둘 수 없습니다. 다시 입력하세요.");
                        Main(args);
                    }

                    Console.WriteLine("입력하신 이름은 {0}입니다!", playerName);
                    Console.WriteLine("");
                    Console.WriteLine("1. 저장");
                    Console.WriteLine("2. 취소");
                    Console.WriteLine("");
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    string job = Console.ReadLine();

                    switch (job)
                    {
                        case "저장":
                            Console.WriteLine("저장되었습니다.");
                            nameConfirmed = true;
                            Console.Clear();
                            Playerjob();
                            break;
                        case "취소":
                            Console.WriteLine("취소되었습니다.");
                            continue;
                        default:
                            Console.WriteLine("잘못된 입력입니다.");
                            continue;
                    }
                }
            }
        }
        static void Playerjob()
        {
            Console.WriteLine("게임을 시작합니다.");
            Console.WriteLine("1: 전사 / 2: 마법사");
            Console.Write("직업을 선택하세요: ");
            string job = Console.ReadLine();

            switch (job)
            {
                case "전사":
                    Console.WriteLine("전사를 선택하셨습니다.");
                    Statistics(10, 8, 100, 50);
                    Console.Clear();
                    warrior_Land();
                    break;
                case "마법사":
                    Console.WriteLine("마법사를 선택하셨습니다");
                    Statistics(5, 10, 70, 60);
                    Console.Clear();
                    magic_Land();
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    Playerjob();
                    break;

            }
        }
        static void magic_Land()
        {
            Console.WriteLine("마법사의 땅에 입장했습니다!");
            Console.WriteLine("마법사의 땅에 오신 여러분 환영합니다");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다");
            Console.WriteLine("");
            Console.WriteLine("1: 스텟 / 2: 인벤 / 3: 상점");
            Console.WriteLine("");
            Console.WriteLine("상태 보기");
            Console.WriteLine("인벤토리");
            Console.WriteLine("상점");
            Console.WriteLine("");
            Console.WriteLine("원하시는 행동을 입력해주세요");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("[마법사] 스테이터스 보기");
                    St();
                    break;
                case "2":
                    Console.WriteLine("인벤토리를 확인합니다.");
                    break;
                case "3":
                    Console.WriteLine("상점에 입장합니다.");
                    break;
                case "4":
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    break;
            }
        }

        static void St()
        {
            Console.WriteLine($"레벨:{Lv}");
            Console.WriteLine($"공격력:{Ap}");
            Console.WriteLine($"채력:{Hp}");
            Console.WriteLine($"방어력:{Def}");
            Console.WriteLine($"골드:{Gold}");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("마을로 돌아갑니다.");
                    Console.Clear();
                    warrior_Land();
                    break;

                case "2":
                    Console.WriteLine("마을로 돌아갑니다.");
                    Console.Clear();
                    magic_Land();
                    break;

            }

        }

        static void warrior_Land()
        {
            Console.WriteLine("전사 지역에 입장했습니다!");
            Console.WriteLine("전사의땅에 오신 여러분 환영합니다");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다");
            Console.WriteLine("");
            Console.WriteLine("1: 스텟 / 2: 인벤 / 3: 상점");
            Console.WriteLine("");
            Console.WriteLine("상태 보기");
            Console.WriteLine("인벤토리");
            Console.WriteLine("상점");
            Console.WriteLine("");
            Console.WriteLine("원하시는 행동을 입력해주세요");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("[전사] 스테이터스 보기");
                    St();
                    break;
                case "2":
                    Console.WriteLine("인벤토리를 확인합니다.");
                    break;
                case "3":
                    Console.WriteLine("상점에 입장합니다.");
                    break;
                case "4":
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 시도해주세요.");
                    break;
            }

            static void Level()
            {
                Lv += 1;
                Statistics(10, 10, 10, 0);
            }
        }
    }
}