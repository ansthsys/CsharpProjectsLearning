/// <summary>
/// Use and Combine Multiple Interfaces
/// <br /><br />
/// Demonstrates how a class can implement and combine multiple interfaces,
/// including interfaces that inherit from another interface. The example
/// shows how different capabilities can be combined into a single class.
/// </summary>

namespace InterfaceCombineMultipleInterfaces
{
    public interface ICanDrive
    {
        void Drive();
    }

    public interface ICanFly
    {
        void Fly();
    }

    public class SuperCar : ICanDrive, ICanFly
    {
        public void Drive()
        {
            Console.WriteLine("SuperCar is driving.");
        }

        public void Fly()
        {
            Console.WriteLine("SuperCar is flying.");
        }
    }

    public interface IControl
    {
        void Play();
        void Pause();
        bool IsPlaying { get; }
    }

    public interface ISkipControl : IControl
    {
        void SkipToNext();
    }

    public interface IVolumeControl : IControl
    {
        void AdjustVolume(int level);
    }

    public class MusicPlayer : ISkipControl, IVolumeControl
    {
        public void Play()
        {
            Console.WriteLine("Music is playing.");
        }

        public void Pause()
        {
            Console.WriteLine("Music is paused.");
        }

        public bool IsPlaying { get; private set; }

        public void SkipToNext()
        {
            Console.WriteLine("Skipped to the next track.");
        }

        public void AdjustVolume(int level)
        {
            Console.WriteLine($"Volume adjusted to {level}.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            SuperCar superCar = new SuperCar();

            superCar.Drive();
            superCar.Fly();

            MusicPlayer musicPlayer = new MusicPlayer();

            musicPlayer.Play();
            musicPlayer.SkipToNext();
            musicPlayer.AdjustVolume(50);
            musicPlayer.Pause();
        }
    }
}
