using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame.Extension
{
    public interface IGameControl
    {
        void SetCollision(TypeGameObject data);
    }

    public interface IMapControl
    {
        event Action<TypeGameObject> OnCollision;        
    }

    public class GameSettings
    {
        public static string AppPath => AppDomain.CurrentDomain.BaseDirectory;
        public static string ImagesPath => "Images";
        public static string ResourcesPath => "Resources";
        public static int StepDelay => 500;
    }

    public enum TypeMove
    {
        Left = 2,
        Right = 3,
        Up = 0,
        Down = 1
    }

    public enum TypeGameObject
    {
        NpcTalk = 1,
        NpcFight = 2,
        Lut = 0,
        CheckPoint = 3
    }

    public class NpcTalk
    {

    }

    public class Lut
    {

    }
}
