package com.mygdx.game;

import com.badlogic.gdx.ApplicationAdapter;
import com.badlogic.gdx.Gdx;
import com.badlogic.gdx.Input;
import com.badlogic.gdx.audio.Music;
import com.badlogic.gdx.graphics.Texture;
import com.badlogic.gdx.graphics.g2d.SpriteBatch;
import com.badlogic.gdx.utils.ScreenUtils;

import java.util.ArrayList;
import java.util.Random;

import com.mygdx.game.lib.*;

public class MyGdxGame extends ApplicationAdapter {
	SpriteBatch batch;
	Texture img, CrossBowMan, Mage, Monk, Peasant, Robber, Sniper, SpearMan;
	Music music;
	public static final int GANG_SIZE = 10;
	public static ArrayList<Unit> whiteSide;
	public static ArrayList<Unit> darkSide;
	public static ArrayList<Unit> allUnits;
	public static int step = 0;
	private static float dx, dy;

	@Override
	public void create() {
		batch = new SpriteBatch();
		img = new Texture("fons/" + String.valueOf(new Random().nextInt(5)) + ".jpg");
		music = Gdx.audio.newMusic(Gdx.files.internal("music/" + String.valueOf(new Random().nextInt(5)) + ".mp3"));
		music.setVolume(.125f);
		music.setLooping(true);
		music.play();
		Init.InitLib();
		Gdx.graphics.setTitle("Герои ООП!");

		int my = 0;
		SpearMan = new Texture("units/SpearMan.jpg");
		my = SpearMan.getHeight();
		Mage = new Texture("units/Mage.jpg");
		Monk = new Texture("units/Monk.jpg");
		Peasant = new Texture("units/Peasant.jpg");
		Robber = new Texture("units/Robber.jpg");
		Sniper = new Texture("units/Sniper.jpg");
		CrossBowMan = new Texture("units/CrossBowMan.jpg");
		dy = dx = Gdx.graphics.getHeight() / 11;
	}

	@Override
	public void render() {
		if (step == 0) {
			Gdx.graphics.setTitle("Первый ход.");
		} else {
			Gdx.graphics.setTitle("Ход номер:" + step);
		}
		batch.begin();
		batch.draw(img, 0, 0, Gdx.graphics.getWidth(), Gdx.graphics.getHeight());
		whiteSide.forEach(n -> {
			switch (n.getInfo()) {
				case "Крестьянин":
					if (n.getHp() > 0)
						batch.draw(Peasant, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
				case "Разбойник":
					if (n.getHp() > 0)
						batch.draw(Robber, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
				case "Снайпер":
					if (n.getHp() > 0)
						batch.draw(Sniper, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
				case "Ведьмак":
					if (n.getHp() > 0)
						batch.draw(Mage, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
			}
		});

		darkSide.forEach(n -> {
			switch (n.getInfo()) {
				case "Монах":
					if (n.getHp() > 0)
						batch.draw(Monk, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
				case "Крестьянин":
					if (n.getHp() > 0)
						batch.draw(Peasant, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
				case "Копейщик":
					if (n.getHp() > 0)
						batch.draw(SpearMan, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
				case "Арбалетчик":
					if (n.getHp() > 0)
						batch.draw(CrossBowMan, n.getCoordinates().getX() * dx, n.getCoordinates().getY() * dy);
					break;
			}
		});

		batch.end();

		if (Gdx.input.isButtonJustPressed(Input.Buttons.LEFT)) {
			step++;
			Init.makeStep();
		}
	}

	@Override
	public void dispose() {
		batch.dispose();
		img.dispose();
	}
}
