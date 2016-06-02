using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {
		cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
		corridor_0, floor, closet_door, stairs_0, corridor_1, in_closet,
		stairs_1, corridor_2, stairs_2, corridor_3, courtyard
		};

	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.sheets_0) {
			state_sheets_0 ();
		} else if (myState == States.mirror) {
			state_mirror ();
		} else if (myState == States.lock_0) {
			state_lock_0 ();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror ();
		} else if (myState == States.sheets_1) {
			state_sheets_1 ();
		} else if (myState == States.lock_1) {
			state_lock_1 ();
		} else if (myState == States.corridor_0) {
			state_corridor_0 ();
		} else if (myState == States.floor) {
			state_floor ();
		} else if (myState == States.stairs_0) {
			state_stairs_0 ();
		} else if (myState == States.closet_door) {
			state_closet_door ();
		} else if (myState == States.corridor_1) {
			state_corridor_1 ();
		} else if (myState == States.in_closet) {
			state_in_closet ();
		} else if (myState == States.stairs_1) {
			state_stairs_1 ();
		} else if (myState == States.corridor_2) {
			state_corridor_2 ();
		} else if (myState == States.stairs_2) {
			state_stairs_2 ();
		} else if (myState == States.corridor_3) {
			state_corridor_3 ();
		} else if (myState == States.courtyard) {
			state_courtyard ();
		}
	}

	void state_cell ()
	{
		text.text = "You are in a dirty prison cell, and you want to escape. There are " +
		"some dirty sheets on the bed, a mirror on the wall, and the door " +
		"is locked from the outside.\n\n" +
		"Press S to view Sheets, M to view Mirror and L to view Lock";
		if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.sheets_0;} 
		else if (Input.GetKeyDown (KeyCode.M)) 	{myState = States.mirror;} 
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_0;} 
	}

	void state_sheets_0 ()
	{
		text.text = "You can't believe you sleep in these things. Surely it's " +
					"time somebody changed them. The pleasures of prison life " +
					"I guess.\n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R))    	{myState = States.cell;}
	}

	void state_sheets_1 ()
	{
		text.text = "Holding a mirror doesn't make the sheets look " +
					"any better.\n\n" +
					"Press R to Return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R))    	{myState = States.cell_mirror;}
	}

	void state_mirror ()
	{
		text.text = "You look at the mirror and notice that it is loose.\n\n" +
					"Press T to take the Mirror and R to return to your cell.";
		if (Input.GetKeyDown (KeyCode.T)) 		{myState = States.cell_mirror;} 
		else if (Input.GetKeyDown (KeyCode.R)) 	{myState = States.cell;}
	}

	void state_cell_mirror ()
	{
		text.text = "You are still in your cell, and you STILL want to excape. " +
		"some dirty sheets on the bed, a mark where the mirror was, " +
		"and that pesky door is still there, and firmly locked!\n\n" +
		"Press S to view the Sheets, or L to view the Lock";
		if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.sheets_1;} 
		else if (Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_1;}
	}

	void state_lock_0 ()
	{
		text.text = "This is one of those button locks. You have no idea what the " +
					"combination is. You wish you could somehow see where the dirty " +
					"fingerprints were, maybe that would help.\n\n" + 
					"Press R to Return to you cell.";
		if (Input.GetKeyDown(KeyCode.R))      	{myState = States.cell;}
	}

	void state_lock_1 ()
	{
		text.text = "You carefully put the mirror through the bars, and turn it round " +
		"so you can see the lock.  You can just make out fingerprints around " +
		"the buttons. You press the dirty buttons, and hear a click.\n\n" +
		"Press O to Open or R to Return to your cell.";
		if (Input.GetKeyDown (KeyCode.O)) 		{myState = States.corridor_0;} 
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;}
	}

	void state_corridor_0 ()
	{
		text.text = "You have escaped your cell and find yourself in a large corridor. " +
		"You something shiny on the floor, some stairs to your right and " +
		"a closet on your left.\n\n" +
		"Press F to inspect the Floor, S to go up the Stairs and C to try the Closet.";
		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.floor;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.closet_door;
		}
	}

	void state_floor ()
	{
		text.text = "Upon inpecting the shiny object on the floor you find a bobbypin, " +
					"and realize that the floors need a good mopping.\n\n" +
					"Press T to Take the bobbypin and R to Return to roaming the Corridor.";
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.corridor_1;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}

	void state_stairs_0 ()
	{
		text.text = "As you approach the stairs you can hear guard clammring above you. " +
					"You realize that if you go this way you will be back in your cell shortly.\n\n" +
					"Press R to Return to the Corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}

	void state_closet_door ()
	{
		text.text = "You inspect the closet door and find that it is locked, if only " +
					"you had a way to pick the lock.\n\n" +
					"Press R to Return to the Corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}

	void state_corridor_1 ()
	{
		text.text = "You have pick up the bobbypin and still have stairs to your right, " +
					"and the locked closet to the left.\n\n" + 
					"Press S to check the Stairs again and P to try to Pick the lock.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_1;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.in_closet;
		}
	}

	void state_stairs_1 ()
	{
		text.text = "You walk to the stairs again and don't hear the gaurds anymore, " +
					"but you do see a shadow of a lone gaurd pulling security at the " +
					"top of the stairs, a bobbypin will be no match for him.\n\n" +
					"Press R to Return to the Corridor.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_1;
		}
	}

	void state_in_closet ()
	{
		text.text = "You gently insert the bobbypin into the lock and turn it counterclock wise, " +
					"the lock clicks and the door opens slightly.  Inside the closet you find " +
					"a mop and a janitor jumpsuit.\n\n" +
					"Press D to Dress in the jumpsuit or R to Return to the Corridor with the Mop.";
		if (Input.GetKeyDown (KeyCode.D)) {
			myState = States.corridor_3;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		}
	}

	void state_corridor_2 ()
	{
		text.text = "You re-enter the corridor armed with a mop. You are still seeing the " +
					"shadow of the guard at the stairs, but your also thinking about that " +
					"jumpsuit back in the closet.\n\n" +
					"Press S to check the Stairs again or C to Checkout the Closet again.";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_2;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.in_closet;
		}
	}

	void state_stairs_2 ()
	{
		text.text = "You sneak up the stairs and one shot the unsuspecting gaurd in the " +
					"head with your mop, knocking him out cold.  You see a window open " +
					"leading to the courtyard.\n\n" +
					"Press C to enter the Courtyard.";
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.courtyard;
		}
	}

	void state_corridor_3 ()
	{
		text.text = "As you enter the corridor with the janitors jumpsuit on a gaurd yells " +
			"at you to evacuate to the courtyard.\n\n" +
			"Press C to enter the Courtyard.";
		if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.courtyard;
		}
	}

	void state_courtyard ()
	{
		text.text = "You have made it to the courtyard and easily jump the fence to freedom.\n\n" +
		"Press P to Play Again.";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}
	}
}
