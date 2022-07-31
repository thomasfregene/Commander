using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommand()
        {
            var commands = new List<Command>
            {
                new Command{Id=1, HowTo = "initialize git", Line="git init", Platform="git"},
                new Command{Id=2, HowTo = "clone repo", Line="git clone", Platform="github"},
                new Command{Id=3, HowTo = "create nodule module", Line="npm init", Platform="nodejs"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 1,
                HowTo = "get command",
                Line = "run command",
                Platform = "git"
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommandDto(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
