﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace coolgame.GUI.Menus
{
    class UpgradeMenu : GUIWindow
    {
        public UpgradeMenu(ContentManager Content, GUIManager guiManager) : base(Content)
        {
            Width = 450;
            Height = 350;
            textPadding = new Vector2(10, 10);
            borderPadding = new Vector2(30, 30);
            Center();

            AddButton(new GUIButton(Content, guiManager.TextFont, "Next Wave", new Vector2(145, 250),textPadding));
            AddButton(new GUIButton(Content, "up_laserDamage", new Vector2(0,0)));
            AddButton(new GUIButton(Content, "up_laserSpeed", new Vector2(40, 0)));
            AddButton(new GUIButton(Content, "up_laserSpread", new Vector2(110, 0)));
            AddButton(new GUIButton(Content, "up_buyturret", new Vector2(160, 0)));
            AddButton(new GUIButton(Content, "up_buyshield", new Vector2(210, 0)));

            Alpha = 220;
            BackgroundColor = CustomColor.DarkBlue;
            SecondaryColor = CustomColor.LightBlue;
        }

        public override void Update(Game game, ContentManager Content, GUIManager guiManager, EnemySpawner spawner)
        {
            base.Update(game, Content, guiManager, spawner);

            if (ButtonPressed(0))
            {
                Disabled = true;
                GameManager.State = GameState.Game;
            }
            if (ButtonPressed(1))
            {
                GameManager.UpgradeLaserPower();
            }
            if (ButtonPressed(2))
            {
                GameManager.UpgradeLaserSpeed();
            }
            if (ButtonPressed(3))
            {
                GameManager.UpgradeLaserSpread();
            }
            if (ButtonPressed(4))
            {
                GameManager.ActivateTurret();
            }
            if (ButtonPressed(5))
            {
                GameManager.ActivateForcefield();
            }
        }
    }
}
