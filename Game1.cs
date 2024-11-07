using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2___Scaling_and_Text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture, rectTexture;
        Rectangle circleRect; 

        SpriteFont textFont;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            circleRect = new Rectangle(10,100,100,50);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            rectTexture = Content.Load<Texture2D>("rectangle");
            textFont = Content.Load<SpriteFont>("TextFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(circleTexture,circleRect, Color.IndianRed);
            _spriteBatch.Draw(rectTexture, new Rectangle(50, 150, 25, 75), Color.IndianRed);
            _spriteBatch.DrawString(textFont, "Carter", new Vector2(250, 250), Color.BlueViolet);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
