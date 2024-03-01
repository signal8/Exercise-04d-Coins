using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CoinHandler
{
	public static int playerCoins = 0;

	public static int getCoins() { return playerCoins; }

	public static void addCoins(int amt) { playerCoins += amt; return; }

	public static void setCoins(int val) { playerCoins = val; return; }
}
