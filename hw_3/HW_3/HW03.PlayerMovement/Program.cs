using System;
using System.Collections.Generic;

namespace HW03.PlayerMovement
{
    enum Rotation
    {
        Up,
        Down,
        Left,
        Right
    }

    static class Pseudographics
    {
        public static char BorderVertical = '\u2551';
        public static char BorderHorizontal = '\u2550';

        public static char Filler = ' ';

        public static char CornerUL = '\u2554';
        public static char CornerUR = '\u2557';
        public static char CornerLL = '\u255A';
        public static char CornerLR = '\u255D';

        //public static char FigureUp = '\u21E7';
        //public static char FigureDown = '\u21E9';
        //public static char FigureLeft = '\u21E6';
        //public static char FigureRight = '\u21E8';
        public static char FigureRight = '>';
        public static char FigureUp = 'A';
        public static char FigureDown = 'V';
        public static char FigureLeft = '<';
    }

    class Player
    {
        (int x, int y) _position;
        Rotation _rotation;
        char _figure;

        public (int x, int y) Position
        {
            get
            {
                return _position;
            }
        }
        public Rotation Rotation
        {
            get
            {
                return _rotation;
            }
        }
        public char Figure
        {
            get
            {
                return _figure;
            }
        }

        public Player(int x = 0, int y = 0, Rotation rotation = Rotation.Up)
        {
            _position = (x: x, y: y);
            _rotation = rotation;
            Rotate(rotation);
        }

        public void Rotate(Rotation direction)
        {
            _rotation = direction;

            switch (_rotation)
            {
                case Rotation.Up:
                    _figure = Pseudographics.FigureUp;
                    break;
                case Rotation.Down:
                    _figure = Pseudographics.FigureDown;
                    break;
                case Rotation.Left:
                    _figure = Pseudographics.FigureLeft;
                    break;
                case Rotation.Right:
                    _figure = Pseudographics.FigureRight;
                    break;
            }
        }

        public void Move()
        {
            switch (_rotation)
            {
                case Rotation.Up:
                    _position.y--;
                    break;
                case Rotation.Down:
                    _position.y++;
                    break;
                case Rotation.Left:
                    _position.x--;
                    break;
                case Rotation.Right:
                    _position.x++;
                    break;
            }
        }
    }

    class Field
    {
        (int x, int y) _oldPlayerPos = (0, 0);
        (int x, int y) _size;
        List<List<char>> _field;
        Player _player;

        public Player Player
        {
            get { return _player; }
            set
            {
                _player = value;
                _oldPlayerPos = (value.Position.x, value.Position.y);
                PlacePlayer();
            }
        }

        public Field(int xSize, int ySize)
        {
            _size = (x: xSize, y: ySize);
            RefreshField();
        }

        public void Redraw()
        {
            Console.Clear();
            PlacePlayer();
            foreach (var row in _field)
            {
                Console.WriteLine(new string(row.ToArray()));
            }
        }

        private void RefreshField()
        {
            _field = new List<List<char>>();

            for (int y = -1; y < _size.y + 1; y++)
            {
                List<char> row = new List<char>();
                char leftBorder = Pseudographics.Filler,
                    rightBorder = Pseudographics.Filler,
                    filler = Pseudographics.Filler;

                switch (y)
                {
                    case int rowNum when y == -1:
                        leftBorder = Pseudographics.CornerUL;
                        rightBorder = Pseudographics.CornerUR;
                        filler = Pseudographics.BorderHorizontal;
                        break;
                    case int rowNum when y > -1 && y < _size.y:
                        leftBorder = Pseudographics.BorderVertical;
                        rightBorder = Pseudographics.BorderVertical;
                        filler = Pseudographics.Filler;
                        break;
                    case int rowNum when y == _size.y:
                        leftBorder = Pseudographics.CornerLL;
                        rightBorder = Pseudographics.CornerLR;
                        filler = Pseudographics.BorderHorizontal;
                        break;
                    default:
                        break;
                }

                row.Add(leftBorder);
                for (int x = 0; x < _size.x; x++)
                {
                    row.Add(filler);
                }
                row.Add(rightBorder);

                _field.Add(row);
            }

            if (!(Player == null))
            {
                PlacePlayer();
            }
        }

        private void PlacePlayer()
        {
            if (_oldPlayerPos.x != Player.Position.x || _oldPlayerPos.y != Player.Position.y)
            {
                _field[_oldPlayerPos.y + 1][_oldPlayerPos.x + 1] = Pseudographics.Filler; // +1 is due to I've drawn borders on the field
            }
            _field[Player.Position.y + 1][Player.Position.x + 1] = Player.Figure; // +1 is due to I've drawn borders on the field
            _oldPlayerPos = (Player.Position.x, Player.Position.y);
        }

        public void ProcessKey(char key)
        {
            bool isMovementAvailable = false;
            Rotation requestedDirection = Rotation.Up;
            switch (key)
            {
                case 'w':
                    requestedDirection = Rotation.Up;
                    if (Player.Position.y > 0)
                        isMovementAvailable = true;
                    break;
                case 'a':
                    requestedDirection = Rotation.Left;
                    if (Player.Position.x > 0)
                        isMovementAvailable = true;
                    break;
                case 's':
                    requestedDirection = Rotation.Down;
                    if (Player.Position.y < _size.y - 1)
                        isMovementAvailable = true;
                    break;
                case 'd':
                    requestedDirection = Rotation.Right;
                    if (Player.Position.x < _size.x - 1)
                        isMovementAvailable = true;
                    break;
                default:
                    break;
            }

            if (Player.Rotation != requestedDirection)
            {
                Player.Rotate(requestedDirection);
            }
            else if (isMovementAvailable)
            {
                Player.Move();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Input:\n - '1': for 'graphical' mode\n - '2': for 'text' mode");
                input = Console.ReadLine();
                if (input == "1" || input == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input not recognized, try again");
                }
            }

            if (input == "1")
            {
                Field field = new Field(40, 20);
                field.Player = new Player(20, 10);
                field.Redraw();

                while (true)
                {
                    field.ProcessKey(char.ToLower(Console.ReadKey().KeyChar));
                    field.Redraw();
                }
            }
            else
            {
                char currentRotation = 'w';
                while (true)
                {
                    bool isInvalidKey = false;
                    char inputKey = char.ToLower(Console.ReadKey().KeyChar);

                    if (currentRotation == inputKey)
                    {
                        Console.WriteLine(" -- rotation skipped --");
                        continue;
                    }

                    switch (inputKey)
                    {
                        case 'w':
                            Console.WriteLine(" -- rotating UP --");
                            break;
                        case 'a':
                            Console.WriteLine(" -- rotating LEFT --");
                            break;
                        case 's':
                            Console.WriteLine(" -- rotating DOWN --");
                            break;
                        case 'd':
                            Console.WriteLine(" -- rotating RIGHT --");
                            break;
                        default:
                            isInvalidKey = true;
                            break;
                    }

                    if (!isInvalidKey)
                    {
                        currentRotation = inputKey;
                    }
                    else
                    {
                        isInvalidKey = false;
                    }
                }
            }
        }
    }
}
