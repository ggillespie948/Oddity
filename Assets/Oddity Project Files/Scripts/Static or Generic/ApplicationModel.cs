﻿public class ApplicationModel {
	public static bool MUSIC_ENABLED = true;
	public static bool FX_ENABLED = true;
	public static int LEVEL_NO = 0;
	public static int WORLD_NO = 0;
	public static string LEVEL_CODE = "";
	public static int GAME_DIFFICULTY = 20;  // /100
	public static int THEME = 3;
	public static int GRID_SIZE = 7;
	public static int MAX_TILE = 8;
	public static int PLAYERS = 2;
	public static int TARGET = 550;
	public static int TARGET2 = 600;
	public static int TARGET3 = 650;
	public static int TURNS = 20;
 	public static int TURN_TIME =30;
	public static bool VS_AI = true;
	public static bool VS_LOCAL_MP = false; //make this an enum
	public static bool SOLO_PLAY = false;
	public static int HUMAN_PLAYERS = 1;
	public static int AI_PLAYERS = 1;
	public static bool TUTORIAL_MODE = false;
	public static int ONE_TILES = 15;
	public static int TWO_TILES = 15;
	public static int THREE_TILES = 15;
	public static int FOUR_TILES = 15;
	public static int FIVE_TILES = 15;
	public static int SIX_TILES = 15;
	public static int SEVEN_TILES = 15;
	public static int RETURN_TO_WORLD =-1;
	public static int TILESKIN = 0;
	public static bool MIRROR_TILESKIN = false;

	public static string Objective1Code = "WinBy.10";
	public static string Objective2Code = "Score.175";
	public static string Objective3Code = "Errors.0"; //less than
}
