using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BooleanTest
{
    public class Boolean_ex09
    {
        #region main

        public bool IsContainThePattern(string text, string sentence)
        {
            //dans une recherche tu dois savoir si la phrase
            //est compris dans un texte.

            return (sentence.Contains(text));
        }
        #endregion
    }
}

