using UnityEngine;
using System.Collections;


public class Menu : MonoBehaviour {

	
    public new string name { get; private set; }//name of Menu
    public Option[] options {get; private set;} //array of options - will be buttons

    public Menu()
    {
        name = "";
        options = null;
    }

    public Menu(string name)
    {
        this.name = name;
        options = null;
    }

    public Menu(Option[] options)
    {
        name = "";
        this.options = (Option[])options.Clone();
    }

    public Menu(string name, Option[] options)
    {
        this.name = name;
        this.options = (Option[])options.Clone();
    }
}
