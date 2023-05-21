using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DecoratorPattern
{
       class Program
    {
        static void Main(string[] args)
        {
            var mundoChamps = new PlayersService();

            var filterDecorate = new ScoredFilterDecorator(mundoChamps);
            var scoredAndAsistPlayers = new AssistFilterDecorator(filterDecorate);

            var resultPlayers = scoredAndAsistPlayers.GetPlayers();
            foreach (var player in resultPlayers)
            {
                Console.WriteLine($"G + A players: {player.Item2}");
            }
        }
    }

    public class PlayersService
    {
        public virtual IEnumerable<(int, string)> GetPlayers()
        {
            return new Collection<(int, string)>()
            {
                (10, "Messi"),
                (20, "Mac Allister"),
                (7, "De Pole"),
                (11, "Di Maria"),
            };
        }
    }

    // i jave a set of object. I want to do set of operations (decorate) with this object

    public class ScoredFilterDecorator : PlayersService
    {
        private readonly PlayersService _component;
        private readonly List<int> _playersScoredList = new() {11, 10};

        public ScoredFilterDecorator(PlayersService component)
        {
            _component = component;
        }

        public override IEnumerable<(int, string)> GetPlayers()
        {
            var playersSet = _component.GetPlayers()
                .Where(player => _playersScoredList.Contains(player.Item1));

            return playersSet;
        }
    }

    public class AssistFilterDecorator : PlayersService
    {
        private readonly PlayersService _component;
        private readonly List<int> _playersScoredList = new() {10};

        public AssistFilterDecorator(PlayersService component)
        {
            _component = component;
        }

        public override IEnumerable<(int, string)> GetPlayers()
        {
            var playersSet = _component.GetPlayers()
                .Where(player => _playersScoredList.Contains(player.Item1));

            return playersSet;
        }
    }
}