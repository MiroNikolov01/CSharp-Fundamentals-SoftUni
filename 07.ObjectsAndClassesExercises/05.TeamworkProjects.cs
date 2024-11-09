namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teamList = new List<Team>();

            int countTeams = int.Parse(Console.ReadLine());

            Team team;
            for (int i = 0; i < countTeams; i++)
            {
                string[] userTeamInfo = Console.ReadLine().Split('-');
                string user = userTeamInfo[0];
                string teamName = userTeamInfo[1];
                team = new Team(teamName, user);

                bool teamExists = teamList.Any(t => t.TeamName == teamName);
                bool userExists = teamList.Any(u => u.User == user);
                if (teamExists)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (userExists)
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }
                teamList.Add(team);

                Console.WriteLine($"Team {team.TeamName} has been created by {team.User}!");
            }
            string cmd;
            while ((cmd = Console.ReadLine()) != "end of assignment")
            {
                string[] joiners = cmd.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string user = joiners[0];
                string teamName = joiners[1];
                bool teamExists = teamList.Any(t => t.TeamName == teamName);
                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                bool alreadyJoined = teamList.Any(t => t.Members.Contains(user) || t.User == user);
                if (alreadyJoined)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }
                Team teamToJoin = teamList.First(t => t.TeamName == teamName);
                teamToJoin.AddMember(user);
            }
            var sortedTeams = teamList
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();
            foreach (var teams in sortedTeams)
            {
                Console.WriteLine(teams.TeamName);
                Console.WriteLine($"- {teams.User}");
                foreach (var member in teams.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var emptyTeams = teamList
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var teams in emptyTeams)
            {
                Console.WriteLine(teams.TeamName);
            }

        }

    }
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string User { get; set; }
        public Team(string teamName, string user)
        {
            TeamName = teamName;
            User = user;
            Members = new List<string>();
        }
        public void AddMember(string user)
        {
            Members.Add(user);
        }


    }
}











