using UnityEngine;


namespace SOSXR.TagSelector
{
    /// <summary>
    ///     From: https://www.brechtos.com/tagselectorattribute/
    ///     Usage:
    ///     public string TagFilter = "";
    ///     public string[] TagFilterArray = new string[] { };
    /// </summary>
    public class TagSelectorAttribute : PropertyAttribute
    {
        public bool UseDefaultTagFieldDrawer = false;
    }
}