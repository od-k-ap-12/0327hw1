using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0327hw1
{
    public class Character
    {
        public double Attack { get; set; }
        public double Speed { get; set; }
        public double Health { get; set; }
        public double Defence { get; set; }
        
    }
    public class Elf:Character
    {
        public Elf()
        {
            Attack = 15;
            Speed = 30;
            Health = 100;
            Defence = 0;
        }

    }
    public class Human:Character
    {
        public Human()
        {
            Attack = 20;
            Speed = 20;
            Health = 150;
            Defence = 0;
        }

    }
    abstract class Decorator
    {
        public Character Character { get; set; }

        public Decorator(Character Character)
        {
            this.Character = Character;
        }

        public void SetComponent(Character Character)
        {
            this.Character = Character;
        }
        public abstract void Move();
        public abstract void ChangeCharacteristics();
    }

    class HumanWarrior : Decorator
    {
        public HumanWarrior(Character Character):base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 20;
            Character.Health += 150;
            Character.Defence += 0;
        }

        public override void Move()
        {
            Character.Speed += 20;
        }
    }

    class HumanSwordsman : Decorator
    {
        public HumanSwordsman(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 40;
            Character.Health += 50;
            Character.Defence += 40;
        }

        public override void Move()
        {
            Character.Speed -= 10;
        }
    }

    class HumanArcher : Decorator
    {
        public HumanArcher(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 20;
            Character.Health += 50;
            Character.Defence += 10;
        }

        public override void Move()
        {
            Character.Speed += 20;
        }
    }
    class HumanHorseman : Decorator
    {
        public HumanHorseman(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack -= 10;
            Character.Health += 200;
            Character.Defence += 100;
        }

        public override void Move()
        {
            Character.Speed += 40;
        }
    }

    class ElfWarrior : Decorator
    {
        public ElfWarrior(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 20;
            Character.Health += 100;
            Character.Defence += 20;
        }

        public override void Move()
        {
            Character.Speed -= 10;
        }
    }

    class ElfMage : Decorator
    {
        public ElfMage(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 10;
            Character.Health -= 50;
            Character.Defence += 10;
        }

        public override void Move()
        {
            Character.Speed += 10;
        }
    }

    class ElfCrossbowman : Decorator
    {
        public ElfCrossbowman(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 20;
            Character.Health += 50;
            Character.Defence -= 10;
        }

        public override void Move()
        {
            Character.Speed += 10;
        }
    }

    class ElfEvilMage : Decorator
    {
        public ElfEvilMage(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 70;
        }

        public override void Move()
        {
            Character.Speed += 20;
        }
    }

    class ElfGoodMage : Decorator
    {
        public ElfGoodMage(Character Character) : base(Character)
        {
            ChangeCharacteristics();
        }

        public override void ChangeCharacteristics()
        {
            Character.Attack += 50;
            Character.Health += 100;
            Character.Defence += 30;
        }

        public override void Move()
        {
            Character.Speed += 30;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
