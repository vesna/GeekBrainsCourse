package com.mygdx.game.lib;

import java.util.ArrayList;

public interface UnitInterface {
    void step(ArrayList<Unit> team);

    String getInfo();
}
