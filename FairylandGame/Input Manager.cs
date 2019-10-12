
using FairylandGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



    public class InputManager
    {
        //OtherKeyBools
        public static bool isEscapepressed;
        public static bool isEnterpressed;
        public static bool isBackSpacepressed;
        public static bool isSpacebarpressed;
        //ControlKeyBools
        public static bool isWpress;
        public bool canWbepress;
        public static bool isSpress;
        public bool canSbepress;
        public static bool isApress;
        public bool canAbepress;
        public static bool isDpress;
        public bool canDbepress;
        //LetterKeyBools
        public static bool isApressed;
        public static bool isBpressed;
        public static bool isCpressed;
        public static bool isDpressed;
        public static bool isEpressed;
        public static bool isFpressed;
        public static bool isGpressed;
        public static bool isHpressed;
        public static bool isIpressed;
        public static bool isJpressed;
        public static bool isKpressed;
        public static bool isLpressed;
        public static bool isMpressed;
        public static bool isNpressed;
        public static bool isOpressed;
        public static bool isPpressed;
        public static bool isQpressed;
        public static bool isRpressed;
        public static bool isSpressed;
        public static bool isTpressed;
        public static bool isUpressed;
        public static bool isVpressed;
        public static bool isWpressed;
        public static bool isXpressed;
        public static bool isYpressed;
        public static bool isZpressed;
        //Number Key Bools
        public static bool is0pressed;
        public static bool is1pressed;
        public static bool is2pressed;
        public static bool is3pressed;
        public static bool is4pressed;
        public static bool is5pressed;
        public static bool is6pressed;
        public static bool is7pressed;
        public static bool is8pressed;
        public static bool is9pressed;
        //NumPad Key Bools
        public static bool isNum0pressed;
        public static bool isNum1pressed;
        public static bool isNum2pressed;
        public static bool isNum3pressed;
        public static bool isNum4pressed;
        public static bool isNum5pressed;
        public static bool isNum6pressed;
        public static bool isNum7pressed;
        public static bool isNum8pressed;
        public static bool isNum9pressed;
        //Mouse Stuff
        public Vector2 mouseCords;
        public Rectangle mouseBox;
        public Rectangle mouseBoxReal;
        public bool rightClick = false;
        public bool leftClick = false;
        public MouseState prevMouseState;
        MouseState currentMouseState;
        KeyboardState keyboardState;
        KeyboardState prevKeyboardState;

        public void Update()
        {

            //Save the Current Mousestate
            currentMouseState = Mouse.GetState();
            keyboardState = Keyboard.GetState();
            //OtherKeyStates
            if (prevKeyboardState.IsKeyDown(Keys.Escape) == false && keyboardState.IsKeyDown(Keys.Escape) == true) { isEscapepressed = true; }
            else { isEscapepressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.Enter) == false && keyboardState.IsKeyDown(Keys.Enter) == true) { isEnterpressed = true; }
            else { isEnterpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.Back) == false && keyboardState.IsKeyDown(Keys.Back) == true) { isBackSpacepressed = true; }
            else { isBackSpacepressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.Space) == false && keyboardState.IsKeyDown(Keys.Space) == true) { isSpacebarpressed = true; }
            else { isSpacebarpressed = false; }
            //inputkeyStates
            if (keyboardState.IsKeyDown(Keys.W) == true) { isWpress = true; }
            else { isWpress = false; }
            if (keyboardState.IsKeyDown(Keys.S) == true) { isSpress = true; }
            else { isSpress = false; }
            if (keyboardState.IsKeyDown(Keys.A) == true) { isApress = true; }
            else { isApress = false; }
            if (keyboardState.IsKeyDown(Keys.D) == true) { isDpress = true; }
            else { isDpress = false; }
            //KeyLetterStates
            if (prevKeyboardState.IsKeyDown(Keys.A) == false && keyboardState.IsKeyDown(Keys.A) == true) { isApressed = true; }
            else { isApressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.B) == false && keyboardState.IsKeyDown(Keys.B) == true) { isBpressed = true; }
            else { isBpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.C) == false && keyboardState.IsKeyDown(Keys.C) == true) { isCpressed = true; }
            else { isCpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D) == false && keyboardState.IsKeyDown(Keys.D) == true) { isDpressed = true; }
            else { isDpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.E) == false && keyboardState.IsKeyDown(Keys.E) == true) { isEpressed = true; }
            else { isEpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.F) == false && keyboardState.IsKeyDown(Keys.F) == true) { isFpressed = true; }
            else { isFpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.G) == false && keyboardState.IsKeyDown(Keys.G) == true) { isGpressed = true; }
            else { isGpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.H) == false && keyboardState.IsKeyDown(Keys.H) == true) { isHpressed = true; }
            else { isHpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.I) == false && keyboardState.IsKeyDown(Keys.I) == true) { isIpressed = true; }
            else { isIpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.J) == false && keyboardState.IsKeyDown(Keys.J) == true) { isJpressed = true; }
            else { isJpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.K) == false && keyboardState.IsKeyDown(Keys.K) == true) { isKpressed = true; }
            else { isKpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.L) == false && keyboardState.IsKeyDown(Keys.L) == true) { isLpressed = true; }
            else { isLpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.M) == false && keyboardState.IsKeyDown(Keys.M) == true) { isMpressed = true; }
            else { isMpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.N) == false && keyboardState.IsKeyDown(Keys.N) == true) { isNpressed = true; }
            else { isNpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.O) == false && keyboardState.IsKeyDown(Keys.O) == true) { isOpressed = true; }
            else { isOpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.P) == false && keyboardState.IsKeyDown(Keys.P) == true) { isPpressed = true; }
            else { isPpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.Q) == false && keyboardState.IsKeyDown(Keys.Q) == true) { isQpressed = true; }
            else { isQpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.R) == false && keyboardState.IsKeyDown(Keys.R) == true) { isRpressed = true; }
            else { isRpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.S) == false && keyboardState.IsKeyDown(Keys.S) == true) { isSpressed = true; }
            else { isSpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.T) == false && keyboardState.IsKeyDown(Keys.T) == true) { isTpressed = true; }
            else { isTpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.U) == false && keyboardState.IsKeyDown(Keys.U) == true) { isUpressed = true; }
            else { isUpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.V) == false && keyboardState.IsKeyDown(Keys.V) == true) { isVpressed = true; }
            else { isVpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.W) == false && keyboardState.IsKeyDown(Keys.W) == true) { isWpressed = true; }
            else { isWpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.X) == false && keyboardState.IsKeyDown(Keys.X) == true) { isXpressed = true; }
            else { isXpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.Y) == false && keyboardState.IsKeyDown(Keys.Y) == true) { isYpressed = true; }
            else { isYpressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.Z) == false && keyboardState.IsKeyDown(Keys.Z) == true) { isZpressed = true; }
            else { isZpressed = false; }
            //Number Key States
            if (prevKeyboardState.IsKeyDown(Keys.D0) == false && keyboardState.IsKeyDown(Keys.D0) == true) { is0pressed = true; }
            else { is0pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D1) == false && keyboardState.IsKeyDown(Keys.D1) == true) { is1pressed = true; }
            else { is1pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D2) == false && keyboardState.IsKeyDown(Keys.D2) == true) { is2pressed = true; }
            else { is2pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D3) == false && keyboardState.IsKeyDown(Keys.D3) == true) { is3pressed = true; }
            else { is3pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D4) == false && keyboardState.IsKeyDown(Keys.D4) == true) { is4pressed = true; }
            else { is4pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D5) == false && keyboardState.IsKeyDown(Keys.D5) == true) { is5pressed = true; }
            else { is5pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D6) == false && keyboardState.IsKeyDown(Keys.D6) == true) { is6pressed = true; }
            else { is6pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D7) == false && keyboardState.IsKeyDown(Keys.D7) == true) { is7pressed = true; }
            else { is7pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D8) == false && keyboardState.IsKeyDown(Keys.D8) == true) { is8pressed = true; }
            else { is8pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.D9) == false && keyboardState.IsKeyDown(Keys.D9) == true) { is9pressed = true; }
            else { is9pressed = false; }
            //NumPad KeyStates
            if (prevKeyboardState.IsKeyDown(Keys.NumPad0) == false && keyboardState.IsKeyDown(Keys.NumPad0) == true) { isNum0pressed = true; }
            else { isNum0pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad1) == false && keyboardState.IsKeyDown(Keys.NumPad1) == true) { isNum1pressed = true; }
            else { isNum1pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad2) == false && keyboardState.IsKeyDown(Keys.NumPad2) == true) { isNum2pressed = true; }
            else { isNum2pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad3) == false && keyboardState.IsKeyDown(Keys.NumPad3) == true) { isNum3pressed = true; }
            else { isNum3pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad4) == false && keyboardState.IsKeyDown(Keys.NumPad4) == true) { isNum4pressed = true; }
            else { isNum4pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad5) == false && keyboardState.IsKeyDown(Keys.NumPad5) == true) { isNum5pressed = true; }
            else { isNum5pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad6) == false && keyboardState.IsKeyDown(Keys.NumPad6) == true) { isNum6pressed = true; }
            else { isNum6pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad7) == false && keyboardState.IsKeyDown(Keys.NumPad7) == true) { isNum7pressed = true; }
            else { isNum7pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad8) == false && keyboardState.IsKeyDown(Keys.NumPad8) == true) { isNum8pressed = true; }
            else { isNum8pressed = false; }
            if (prevKeyboardState.IsKeyDown(Keys.NumPad9) == false && keyboardState.IsKeyDown(Keys.NumPad9) == true) { isNum9pressed = true; }
            else { isNum9pressed = false; }

            //Alt-Enter Fullscreen Shortcut
            //if (prevKeyboardState.IsKeyDown(Keys.Enter) == false && keyboardState.IsKeyDown(Keys.LeftAlt) == true && keyboardState.IsKeyDown(Keys.Enter) == true)
            //{
            //    if (Game1.isWindowed == false) { Game1.isWindowed = true; }
            //    else { Game1.isWindowed = false; }
            //    FileSaver.SaveSettings();
           // }
            //Run Mouse Code
            
            //End Update by saving State for future use
            prevKeyboardState = keyboardState;
            prevMouseState = currentMouseState;

            //if (Game1.lockMouse == true)
            {

            }
            //if (Game1.lockMouse == false) { }
        }
        //end of class
    }


