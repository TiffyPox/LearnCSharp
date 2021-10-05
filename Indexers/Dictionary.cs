using System.Collections.Generic;

namespace Indexers
{
    public class Dictionary
    {
        private readonly List<string> _names = new List<string>();
        private readonly List<string> _definitions = new List<string>();

        public string this[string name]
        {
            get
            {
                var indexOf = _names.IndexOf(name);
                if (indexOf != -1)
                {
                    return _definitions[indexOf];
                }

                return "The key does not exist";
            }
            set
            {
                var indexOf = _names.IndexOf(name);
                if (indexOf == -1)
                {
                    _names.Add(name);
                    _definitions.Add(value);
                }
                else
                {
                    _definitions[indexOf] = value;
                }
            }
        }
    }
}