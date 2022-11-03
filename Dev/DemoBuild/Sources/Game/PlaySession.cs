﻿using DialogueEditor;
using System.Collections.Generic;

namespace DemoBuild
{
    public class PlaySession
    {
        protected Dictionary<string, int> honor = new Dictionary<string, int>();

        public void AddHonor(string character, int value)
        {
            if (honor.ContainsKey(character))
            {
                honor[character] += value;
            }
            else
            {
                honor.Add(character, value);
            }

            string name = ResourcesHandler.Project.GetActorName(character);
            if (string.IsNullOrEmpty(name))
            {
                name = character;
            }

            EditorCore.LogInfo($"{name} now has an honor value of {honor[character]}");
        }

        public bool HasHonor(string character, int min, int max)
        {
            if (honor.ContainsKey(character))
            {
                int value = honor[character];
                return value >= min && value <= max;
            }
            else
            {
                return false;
            }
        }
    }
}
