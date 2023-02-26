using System.IO;
using System.Media;
using System.Numerics;
using System.Windows.Forms;
using Game.Properties;

namespace Game
{
    public partial class PacMan : Form
    {
        public const int WINDOW_WIDTH = 1357;
        public const int WINDOW_HEIGHT = 600;
        bool up, down, left, right, isGameOver;
        int score = 0, playerSpeed = 10, redGhostSpeed = 1, yellowGhostSpeed = 1, pinkGhostSpeed = 1;
        string directionBlock;
        private PictureBox gameScreen;
        public PacMan()
        {
            
            InitializeComponent();
            gameScreen = new PictureBox();
            gameScreen.BackColor = Color.Black;
            Controls.Add(gameScreen);
            // Set up the form
            Text = "Pacman";
            ClientSize = new Size(WINDOW_WIDTH, WINDOW_HEIGHT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            pictureBox30.Visible = false;
            pictureBox455.Visible = false;
            label2.Visible = false;
            timer1.Stop();
            SoundPlayer sp = new SoundPlayer("intropacman.wav");
            sp.PlayLooping();
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.pictureBox77 = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.pictureBox91 = new System.Windows.Forms.PictureBox();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.pictureBox94 = new System.Windows.Forms.PictureBox();
            this.pictureBox95 = new System.Windows.Forms.PictureBox();
            this.pictureBox96 = new System.Windows.Forms.PictureBox();
            this.pictureBox97 = new System.Windows.Forms.PictureBox();
            this.pictureBox98 = new System.Windows.Forms.PictureBox();
            this.pictureBox99 = new System.Windows.Forms.PictureBox();
            this.pictureBox100 = new System.Windows.Forms.PictureBox();
            this.pictureBox101 = new System.Windows.Forms.PictureBox();
            this.pictureBox102 = new System.Windows.Forms.PictureBox();
            this.pictureBox103 = new System.Windows.Forms.PictureBox();
            this.pictureBox104 = new System.Windows.Forms.PictureBox();
            this.pictureBox105 = new System.Windows.Forms.PictureBox();
            this.pictureBox106 = new System.Windows.Forms.PictureBox();
            this.pictureBox107 = new System.Windows.Forms.PictureBox();
            this.pictureBox108 = new System.Windows.Forms.PictureBox();
            this.pictureBox109 = new System.Windows.Forms.PictureBox();
            this.pictureBox110 = new System.Windows.Forms.PictureBox();
            this.pictureBox111 = new System.Windows.Forms.PictureBox();
            this.pictureBox112 = new System.Windows.Forms.PictureBox();
            this.pictureBox113 = new System.Windows.Forms.PictureBox();
            this.pictureBox114 = new System.Windows.Forms.PictureBox();
            this.pictureBox115 = new System.Windows.Forms.PictureBox();
            this.pictureBox116 = new System.Windows.Forms.PictureBox();
            this.pictureBox117 = new System.Windows.Forms.PictureBox();
            this.pictureBox118 = new System.Windows.Forms.PictureBox();
            this.pictureBox119 = new System.Windows.Forms.PictureBox();
            this.pictureBox120 = new System.Windows.Forms.PictureBox();
            this.pictureBox121 = new System.Windows.Forms.PictureBox();
            this.pictureBox122 = new System.Windows.Forms.PictureBox();
            this.pictureBox123 = new System.Windows.Forms.PictureBox();
            this.pictureBox124 = new System.Windows.Forms.PictureBox();
            this.pictureBox125 = new System.Windows.Forms.PictureBox();
            this.pictureBox126 = new System.Windows.Forms.PictureBox();
            this.pictureBox127 = new System.Windows.Forms.PictureBox();
            this.pictureBox128 = new System.Windows.Forms.PictureBox();
            this.pictureBox129 = new System.Windows.Forms.PictureBox();
            this.pictureBox130 = new System.Windows.Forms.PictureBox();
            this.pictureBox131 = new System.Windows.Forms.PictureBox();
            this.pictureBox132 = new System.Windows.Forms.PictureBox();
            this.pictureBox133 = new System.Windows.Forms.PictureBox();
            this.pictureBox134 = new System.Windows.Forms.PictureBox();
            this.pictureBox135 = new System.Windows.Forms.PictureBox();
            this.pictureBox136 = new System.Windows.Forms.PictureBox();
            this.pictureBox137 = new System.Windows.Forms.PictureBox();
            this.pictureBox138 = new System.Windows.Forms.PictureBox();
            this.pictureBox139 = new System.Windows.Forms.PictureBox();
            this.pictureBox140 = new System.Windows.Forms.PictureBox();
            this.pictureBox141 = new System.Windows.Forms.PictureBox();
            this.pictureBox142 = new System.Windows.Forms.PictureBox();
            this.pictureBox143 = new System.Windows.Forms.PictureBox();
            this.pictureBox144 = new System.Windows.Forms.PictureBox();
            this.pictureBox145 = new System.Windows.Forms.PictureBox();
            this.pictureBox146 = new System.Windows.Forms.PictureBox();
            this.pictureBox147 = new System.Windows.Forms.PictureBox();
            this.pictureBox148 = new System.Windows.Forms.PictureBox();
            this.pictureBox149 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox150 = new System.Windows.Forms.PictureBox();
            this.pictureBox151 = new System.Windows.Forms.PictureBox();
            this.pictureBox152 = new System.Windows.Forms.PictureBox();
            this.pictureBox153 = new System.Windows.Forms.PictureBox();
            this.pictureBox154 = new System.Windows.Forms.PictureBox();
            this.pictureBox155 = new System.Windows.Forms.PictureBox();
            this.pictureBox156 = new System.Windows.Forms.PictureBox();
            this.pictureBox157 = new System.Windows.Forms.PictureBox();
            this.pictureBox158 = new System.Windows.Forms.PictureBox();
            this.pictureBox159 = new System.Windows.Forms.PictureBox();
            this.pictureBox160 = new System.Windows.Forms.PictureBox();
            this.pictureBox161 = new System.Windows.Forms.PictureBox();
            this.pictureBox162 = new System.Windows.Forms.PictureBox();
            this.pictureBox163 = new System.Windows.Forms.PictureBox();
            this.pictureBox164 = new System.Windows.Forms.PictureBox();
            this.pictureBox165 = new System.Windows.Forms.PictureBox();
            this.pictureBox166 = new System.Windows.Forms.PictureBox();
            this.pictureBox167 = new System.Windows.Forms.PictureBox();
            this.pictureBox168 = new System.Windows.Forms.PictureBox();
            this.pictureBox169 = new System.Windows.Forms.PictureBox();
            this.pictureBox170 = new System.Windows.Forms.PictureBox();
            this.pictureBox171 = new System.Windows.Forms.PictureBox();
            this.pictureBox172 = new System.Windows.Forms.PictureBox();
            this.pictureBox173 = new System.Windows.Forms.PictureBox();
            this.pictureBox174 = new System.Windows.Forms.PictureBox();
            this.pictureBox175 = new System.Windows.Forms.PictureBox();
            this.pictureBox176 = new System.Windows.Forms.PictureBox();
            this.pictureBox177 = new System.Windows.Forms.PictureBox();
            this.pictureBox178 = new System.Windows.Forms.PictureBox();
            this.pictureBox179 = new System.Windows.Forms.PictureBox();
            this.pictureBox180 = new System.Windows.Forms.PictureBox();
            this.pictureBox181 = new System.Windows.Forms.PictureBox();
            this.pictureBox182 = new System.Windows.Forms.PictureBox();
            this.pictureBox183 = new System.Windows.Forms.PictureBox();
            this.pictureBox184 = new System.Windows.Forms.PictureBox();
            this.pictureBox185 = new System.Windows.Forms.PictureBox();
            this.pictureBox186 = new System.Windows.Forms.PictureBox();
            this.pictureBox187 = new System.Windows.Forms.PictureBox();
            this.pictureBox188 = new System.Windows.Forms.PictureBox();
            this.pictureBox189 = new System.Windows.Forms.PictureBox();
            this.pictureBox190 = new System.Windows.Forms.PictureBox();
            this.pictureBox191 = new System.Windows.Forms.PictureBox();
            this.pictureBox192 = new System.Windows.Forms.PictureBox();
            this.pictureBox193 = new System.Windows.Forms.PictureBox();
            this.pictureBox194 = new System.Windows.Forms.PictureBox();
            this.pictureBox195 = new System.Windows.Forms.PictureBox();
            this.pictureBox196 = new System.Windows.Forms.PictureBox();
            this.pictureBox197 = new System.Windows.Forms.PictureBox();
            this.pictureBox198 = new System.Windows.Forms.PictureBox();
            this.pictureBox199 = new System.Windows.Forms.PictureBox();
            this.pictureBox200 = new System.Windows.Forms.PictureBox();
            this.pictureBox201 = new System.Windows.Forms.PictureBox();
            this.pictureBox202 = new System.Windows.Forms.PictureBox();
            this.pictureBox203 = new System.Windows.Forms.PictureBox();
            this.pictureBox204 = new System.Windows.Forms.PictureBox();
            this.pictureBox205 = new System.Windows.Forms.PictureBox();
            this.pictureBox206 = new System.Windows.Forms.PictureBox();
            this.pictureBox207 = new System.Windows.Forms.PictureBox();
            this.pictureBox208 = new System.Windows.Forms.PictureBox();
            this.pictureBox209 = new System.Windows.Forms.PictureBox();
            this.pictureBox210 = new System.Windows.Forms.PictureBox();
            this.pictureBox211 = new System.Windows.Forms.PictureBox();
            this.pictureBox212 = new System.Windows.Forms.PictureBox();
            this.pictureBox213 = new System.Windows.Forms.PictureBox();
            this.pictureBox214 = new System.Windows.Forms.PictureBox();
            this.pictureBox215 = new System.Windows.Forms.PictureBox();
            this.pictureBox216 = new System.Windows.Forms.PictureBox();
            this.pictureBox217 = new System.Windows.Forms.PictureBox();
            this.pictureBox218 = new System.Windows.Forms.PictureBox();
            this.pictureBox219 = new System.Windows.Forms.PictureBox();
            this.pictureBox220 = new System.Windows.Forms.PictureBox();
            this.pictureBox221 = new System.Windows.Forms.PictureBox();
            this.pictureBox222 = new System.Windows.Forms.PictureBox();
            this.pictureBox223 = new System.Windows.Forms.PictureBox();
            this.pictureBox224 = new System.Windows.Forms.PictureBox();
            this.pictureBox225 = new System.Windows.Forms.PictureBox();
            this.pictureBox226 = new System.Windows.Forms.PictureBox();
            this.pictureBox227 = new System.Windows.Forms.PictureBox();
            this.pictureBox228 = new System.Windows.Forms.PictureBox();
            this.pictureBox229 = new System.Windows.Forms.PictureBox();
            this.pictureBox230 = new System.Windows.Forms.PictureBox();
            this.pictureBox231 = new System.Windows.Forms.PictureBox();
            this.pictureBox232 = new System.Windows.Forms.PictureBox();
            this.pictureBox233 = new System.Windows.Forms.PictureBox();
            this.pictureBox234 = new System.Windows.Forms.PictureBox();
            this.pictureBox235 = new System.Windows.Forms.PictureBox();
            this.pictureBox236 = new System.Windows.Forms.PictureBox();
            this.pictureBox237 = new System.Windows.Forms.PictureBox();
            this.pictureBox238 = new System.Windows.Forms.PictureBox();
            this.pictureBox239 = new System.Windows.Forms.PictureBox();
            this.pictureBox240 = new System.Windows.Forms.PictureBox();
            this.pictureBox241 = new System.Windows.Forms.PictureBox();
            this.pictureBox242 = new System.Windows.Forms.PictureBox();
            this.pictureBox243 = new System.Windows.Forms.PictureBox();
            this.pictureBox244 = new System.Windows.Forms.PictureBox();
            this.pictureBox245 = new System.Windows.Forms.PictureBox();
            this.pictureBox246 = new System.Windows.Forms.PictureBox();
            this.pictureBox247 = new System.Windows.Forms.PictureBox();
            this.pictureBox248 = new System.Windows.Forms.PictureBox();
            this.pictureBox249 = new System.Windows.Forms.PictureBox();
            this.pictureBox250 = new System.Windows.Forms.PictureBox();
            this.pictureBox251 = new System.Windows.Forms.PictureBox();
            this.pictureBox252 = new System.Windows.Forms.PictureBox();
            this.pictureBox253 = new System.Windows.Forms.PictureBox();
            this.pictureBox254 = new System.Windows.Forms.PictureBox();
            this.pictureBox255 = new System.Windows.Forms.PictureBox();
            this.pictureBox256 = new System.Windows.Forms.PictureBox();
            this.pictureBox257 = new System.Windows.Forms.PictureBox();
            this.pictureBox258 = new System.Windows.Forms.PictureBox();
            this.pictureBox259 = new System.Windows.Forms.PictureBox();
            this.pictureBox260 = new System.Windows.Forms.PictureBox();
            this.pictureBox261 = new System.Windows.Forms.PictureBox();
            this.pictureBox262 = new System.Windows.Forms.PictureBox();
            this.pictureBox263 = new System.Windows.Forms.PictureBox();
            this.pictureBox264 = new System.Windows.Forms.PictureBox();
            this.pictureBox265 = new System.Windows.Forms.PictureBox();
            this.pictureBox266 = new System.Windows.Forms.PictureBox();
            this.pictureBox267 = new System.Windows.Forms.PictureBox();
            this.pictureBox268 = new System.Windows.Forms.PictureBox();
            this.pictureBox269 = new System.Windows.Forms.PictureBox();
            this.pictureBox270 = new System.Windows.Forms.PictureBox();
            this.pictureBox271 = new System.Windows.Forms.PictureBox();
            this.pictureBox272 = new System.Windows.Forms.PictureBox();
            this.pictureBox273 = new System.Windows.Forms.PictureBox();
            this.pictureBox274 = new System.Windows.Forms.PictureBox();
            this.pictureBox275 = new System.Windows.Forms.PictureBox();
            this.pictureBox276 = new System.Windows.Forms.PictureBox();
            this.pictureBox277 = new System.Windows.Forms.PictureBox();
            this.pictureBox278 = new System.Windows.Forms.PictureBox();
            this.pictureBox279 = new System.Windows.Forms.PictureBox();
            this.pictureBox280 = new System.Windows.Forms.PictureBox();
            this.pictureBox281 = new System.Windows.Forms.PictureBox();
            this.pictureBox282 = new System.Windows.Forms.PictureBox();
            this.pictureBox283 = new System.Windows.Forms.PictureBox();
            this.pictureBox284 = new System.Windows.Forms.PictureBox();
            this.pictureBox285 = new System.Windows.Forms.PictureBox();
            this.pictureBox286 = new System.Windows.Forms.PictureBox();
            this.pictureBox287 = new System.Windows.Forms.PictureBox();
            this.pictureBox288 = new System.Windows.Forms.PictureBox();
            this.pictureBox289 = new System.Windows.Forms.PictureBox();
            this.pictureBox290 = new System.Windows.Forms.PictureBox();
            this.pictureBox291 = new System.Windows.Forms.PictureBox();
            this.pictureBox292 = new System.Windows.Forms.PictureBox();
            this.pictureBox293 = new System.Windows.Forms.PictureBox();
            this.pictureBox294 = new System.Windows.Forms.PictureBox();
            this.pictureBox295 = new System.Windows.Forms.PictureBox();
            this.pictureBox296 = new System.Windows.Forms.PictureBox();
            this.pictureBox297 = new System.Windows.Forms.PictureBox();
            this.pictureBox298 = new System.Windows.Forms.PictureBox();
            this.pictureBox299 = new System.Windows.Forms.PictureBox();
            this.pictureBox300 = new System.Windows.Forms.PictureBox();
            this.pictureBox301 = new System.Windows.Forms.PictureBox();
            this.pictureBox302 = new System.Windows.Forms.PictureBox();
            this.pictureBox303 = new System.Windows.Forms.PictureBox();
            this.pictureBox304 = new System.Windows.Forms.PictureBox();
            this.pictureBox305 = new System.Windows.Forms.PictureBox();
            this.pictureBox306 = new System.Windows.Forms.PictureBox();
            this.pictureBox307 = new System.Windows.Forms.PictureBox();
            this.pictureBox308 = new System.Windows.Forms.PictureBox();
            this.pictureBox309 = new System.Windows.Forms.PictureBox();
            this.pictureBox310 = new System.Windows.Forms.PictureBox();
            this.pictureBox311 = new System.Windows.Forms.PictureBox();
            this.pictureBox312 = new System.Windows.Forms.PictureBox();
            this.pictureBox313 = new System.Windows.Forms.PictureBox();
            this.pictureBox314 = new System.Windows.Forms.PictureBox();
            this.pictureBox315 = new System.Windows.Forms.PictureBox();
            this.pictureBox316 = new System.Windows.Forms.PictureBox();
            this.pictureBox317 = new System.Windows.Forms.PictureBox();
            this.pictureBox318 = new System.Windows.Forms.PictureBox();
            this.pictureBox319 = new System.Windows.Forms.PictureBox();
            this.pictureBox320 = new System.Windows.Forms.PictureBox();
            this.pictureBox321 = new System.Windows.Forms.PictureBox();
            this.pictureBox322 = new System.Windows.Forms.PictureBox();
            this.pictureBox323 = new System.Windows.Forms.PictureBox();
            this.pictureBox324 = new System.Windows.Forms.PictureBox();
            this.pictureBox325 = new System.Windows.Forms.PictureBox();
            this.pictureBox326 = new System.Windows.Forms.PictureBox();
            this.pictureBox327 = new System.Windows.Forms.PictureBox();
            this.pictureBox328 = new System.Windows.Forms.PictureBox();
            this.pictureBox329 = new System.Windows.Forms.PictureBox();
            this.pictureBox330 = new System.Windows.Forms.PictureBox();
            this.pictureBox331 = new System.Windows.Forms.PictureBox();
            this.pictureBox332 = new System.Windows.Forms.PictureBox();
            this.pictureBox333 = new System.Windows.Forms.PictureBox();
            this.pictureBox334 = new System.Windows.Forms.PictureBox();
            this.pictureBox335 = new System.Windows.Forms.PictureBox();
            this.pictureBox336 = new System.Windows.Forms.PictureBox();
            this.pictureBox337 = new System.Windows.Forms.PictureBox();
            this.pictureBox338 = new System.Windows.Forms.PictureBox();
            this.pictureBox339 = new System.Windows.Forms.PictureBox();
            this.pictureBox340 = new System.Windows.Forms.PictureBox();
            this.pictureBox341 = new System.Windows.Forms.PictureBox();
            this.pictureBox342 = new System.Windows.Forms.PictureBox();
            this.pictureBox343 = new System.Windows.Forms.PictureBox();
            this.pictureBox344 = new System.Windows.Forms.PictureBox();
            this.pictureBox345 = new System.Windows.Forms.PictureBox();
            this.pictureBox346 = new System.Windows.Forms.PictureBox();
            this.pictureBox347 = new System.Windows.Forms.PictureBox();
            this.pictureBox348 = new System.Windows.Forms.PictureBox();
            this.pictureBox349 = new System.Windows.Forms.PictureBox();
            this.pictureBox350 = new System.Windows.Forms.PictureBox();
            this.pictureBox351 = new System.Windows.Forms.PictureBox();
            this.pictureBox352 = new System.Windows.Forms.PictureBox();
            this.pictureBox353 = new System.Windows.Forms.PictureBox();
            this.pictureBox354 = new System.Windows.Forms.PictureBox();
            this.pictureBox355 = new System.Windows.Forms.PictureBox();
            this.pictureBox356 = new System.Windows.Forms.PictureBox();
            this.pictureBox357 = new System.Windows.Forms.PictureBox();
            this.pictureBox358 = new System.Windows.Forms.PictureBox();
            this.pictureBox359 = new System.Windows.Forms.PictureBox();
            this.pictureBox360 = new System.Windows.Forms.PictureBox();
            this.pictureBox361 = new System.Windows.Forms.PictureBox();
            this.pictureBox362 = new System.Windows.Forms.PictureBox();
            this.pictureBox363 = new System.Windows.Forms.PictureBox();
            this.pictureBox364 = new System.Windows.Forms.PictureBox();
            this.pictureBox365 = new System.Windows.Forms.PictureBox();
            this.pictureBox366 = new System.Windows.Forms.PictureBox();
            this.pictureBox367 = new System.Windows.Forms.PictureBox();
            this.pictureBox368 = new System.Windows.Forms.PictureBox();
            this.pictureBox369 = new System.Windows.Forms.PictureBox();
            this.pictureBox370 = new System.Windows.Forms.PictureBox();
            this.pictureBox371 = new System.Windows.Forms.PictureBox();
            this.pictureBox372 = new System.Windows.Forms.PictureBox();
            this.pictureBox373 = new System.Windows.Forms.PictureBox();
            this.pictureBox374 = new System.Windows.Forms.PictureBox();
            this.pictureBox375 = new System.Windows.Forms.PictureBox();
            this.pictureBox376 = new System.Windows.Forms.PictureBox();
            this.pictureBox377 = new System.Windows.Forms.PictureBox();
            this.pictureBox378 = new System.Windows.Forms.PictureBox();
            this.pictureBox379 = new System.Windows.Forms.PictureBox();
            this.pictureBox380 = new System.Windows.Forms.PictureBox();
            this.pictureBox381 = new System.Windows.Forms.PictureBox();
            this.pictureBox382 = new System.Windows.Forms.PictureBox();
            this.pictureBox383 = new System.Windows.Forms.PictureBox();
            this.pictureBox384 = new System.Windows.Forms.PictureBox();
            this.pictureBox385 = new System.Windows.Forms.PictureBox();
            this.pictureBox386 = new System.Windows.Forms.PictureBox();
            this.pictureBox387 = new System.Windows.Forms.PictureBox();
            this.pictureBox388 = new System.Windows.Forms.PictureBox();
            this.pictureBox389 = new System.Windows.Forms.PictureBox();
            this.pictureBox390 = new System.Windows.Forms.PictureBox();
            this.pictureBox391 = new System.Windows.Forms.PictureBox();
            this.pictureBox392 = new System.Windows.Forms.PictureBox();
            this.pictureBox393 = new System.Windows.Forms.PictureBox();
            this.pictureBox394 = new System.Windows.Forms.PictureBox();
            this.pictureBox395 = new System.Windows.Forms.PictureBox();
            this.pictureBox396 = new System.Windows.Forms.PictureBox();
            this.pictureBox397 = new System.Windows.Forms.PictureBox();
            this.pictureBox398 = new System.Windows.Forms.PictureBox();
            this.pictureBox399 = new System.Windows.Forms.PictureBox();
            this.pictureBox400 = new System.Windows.Forms.PictureBox();
            this.pictureBox401 = new System.Windows.Forms.PictureBox();
            this.pictureBox402 = new System.Windows.Forms.PictureBox();
            this.pictureBox403 = new System.Windows.Forms.PictureBox();
            this.pictureBox404 = new System.Windows.Forms.PictureBox();
            this.pictureBox405 = new System.Windows.Forms.PictureBox();
            this.pictureBox406 = new System.Windows.Forms.PictureBox();
            this.pictureBox407 = new System.Windows.Forms.PictureBox();
            this.pictureBox408 = new System.Windows.Forms.PictureBox();
            this.pictureBox409 = new System.Windows.Forms.PictureBox();
            this.pictureBox410 = new System.Windows.Forms.PictureBox();
            this.pictureBox411 = new System.Windows.Forms.PictureBox();
            this.pictureBox412 = new System.Windows.Forms.PictureBox();
            this.pictureBox413 = new System.Windows.Forms.PictureBox();
            this.pictureBox414 = new System.Windows.Forms.PictureBox();
            this.pictureBox415 = new System.Windows.Forms.PictureBox();
            this.pictureBox416 = new System.Windows.Forms.PictureBox();
            this.pictureBox417 = new System.Windows.Forms.PictureBox();
            this.pictureBox418 = new System.Windows.Forms.PictureBox();
            this.pictureBox419 = new System.Windows.Forms.PictureBox();
            this.pictureBox420 = new System.Windows.Forms.PictureBox();
            this.pictureBox421 = new System.Windows.Forms.PictureBox();
            this.pictureBox422 = new System.Windows.Forms.PictureBox();
            this.pictureBox423 = new System.Windows.Forms.PictureBox();
            this.pictureBox424 = new System.Windows.Forms.PictureBox();
            this.pictureBox425 = new System.Windows.Forms.PictureBox();
            this.pictureBox426 = new System.Windows.Forms.PictureBox();
            this.pictureBox428 = new System.Windows.Forms.PictureBox();
            this.pictureBox429 = new System.Windows.Forms.PictureBox();
            this.pictureBox430 = new System.Windows.Forms.PictureBox();
            this.pictureBox431 = new System.Windows.Forms.PictureBox();
            this.pictureBox432 = new System.Windows.Forms.PictureBox();
            this.pictureBox433 = new System.Windows.Forms.PictureBox();
            this.pictureBox434 = new System.Windows.Forms.PictureBox();
            this.pictureBox435 = new System.Windows.Forms.PictureBox();
            this.pictureBox436 = new System.Windows.Forms.PictureBox();
            this.pictureBox437 = new System.Windows.Forms.PictureBox();
            this.pictureBox438 = new System.Windows.Forms.PictureBox();
            this.pictureBox439 = new System.Windows.Forms.PictureBox();
            this.pictureBox440 = new System.Windows.Forms.PictureBox();
            this.pictureBox427 = new System.Windows.Forms.PictureBox();
            this.pictureBox441 = new System.Windows.Forms.PictureBox();
            this.pictureBox442 = new System.Windows.Forms.PictureBox();
            this.pictureBox443 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox444 = new System.Windows.Forms.PictureBox();
            this.pictureBox445 = new System.Windows.Forms.PictureBox();
            this.pictureBox446 = new System.Windows.Forms.PictureBox();
            this.pictureBox447 = new System.Windows.Forms.PictureBox();
            this.pictureBox448 = new System.Windows.Forms.PictureBox();
            this.pictureBox449 = new System.Windows.Forms.PictureBox();
            this.pictureBox450 = new System.Windows.Forms.PictureBox();
            this.pictureBox451 = new System.Windows.Forms.PictureBox();
            this.pictureBox452 = new System.Windows.Forms.PictureBox();
            this.pictureBox453 = new System.Windows.Forms.PictureBox();
            this.pictureBox454 = new System.Windows.Forms.PictureBox();
            this.pacman2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox455 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox106)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox107)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox108)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox112)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox113)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox114)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox115)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox116)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox117)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox118)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox120)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox121)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox124)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox129)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox130)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox131)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox132)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox133)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox136)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox137)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox138)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox139)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox140)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox142)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox146)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox147)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox148)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox149)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox150)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox152)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox154)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox155)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox156)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox157)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox158)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox159)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox160)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox161)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox162)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox163)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox164)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox165)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox166)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox168)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox169)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox170)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox171)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox172)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox173)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox174)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox175)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox176)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox177)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox178)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox179)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox180)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox181)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox185)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox186)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox187)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox188)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox189)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox190)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox191)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox192)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox193)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox194)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox195)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox199)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox201)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox202)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox203)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox204)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox205)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox206)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox207)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox208)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox209)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox210)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox211)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox212)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox213)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox214)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox215)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox216)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox217)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox218)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox219)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox220)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox221)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox222)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox223)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox224)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox225)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox226)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox227)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox228)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox229)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox230)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox231)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox232)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox233)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox234)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox235)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox236)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox237)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox238)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox239)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox240)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox241)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox242)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox243)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox244)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox245)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox246)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox247)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox248)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox249)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox250)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox251)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox252)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox253)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox254)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox255)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox256)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox257)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox258)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox259)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox260)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox261)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox262)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox263)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox264)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox265)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox266)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox267)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox268)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox269)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox270)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox271)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox272)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox273)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox274)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox275)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox276)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox277)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox278)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox279)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox280)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox281)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox282)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox283)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox284)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox285)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox286)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox287)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox288)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox289)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox290)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox291)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox292)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox293)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox294)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox295)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox296)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox297)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox298)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox299)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox300)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox301)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox302)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox303)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox304)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox305)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox306)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox307)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox308)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox309)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox310)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox311)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox312)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox313)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox314)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox315)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox316)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox317)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox318)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox319)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox320)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox321)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox322)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox323)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox324)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox325)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox326)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox327)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox328)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox329)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox330)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox331)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox332)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox333)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox334)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox335)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox336)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox337)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox338)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox339)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox340)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox341)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox342)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox343)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox344)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox345)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox346)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox347)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox348)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox349)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox350)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox351)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox352)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox353)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox354)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox355)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox356)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox357)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox358)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox359)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox361)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox362)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox363)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox364)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox365)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox366)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox367)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox368)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox369)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox370)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox371)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox372)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox373)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox374)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox375)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox376)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox377)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox378)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox379)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox380)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox381)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox382)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox383)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox384)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox385)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox386)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox387)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox388)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox389)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox390)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox391)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox392)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox393)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox394)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox395)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox396)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox397)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox398)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox399)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox400)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox401)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox402)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox403)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox404)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox405)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox406)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox407)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox408)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox409)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox410)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox411)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox412)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox413)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox414)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox415)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox416)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox417)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox418)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox419)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox420)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox421)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox422)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox423)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox424)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox425)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox426)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox428)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox429)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox430)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox431)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox432)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox433)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox434)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox435)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox436)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox437)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox438)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox439)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox440)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox427)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox441)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox442)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox443)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox444)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox445)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox446)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox447)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox448)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox449)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox450)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox451)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox452)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox453)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox454)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox455)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score.Location = new System.Drawing.Point(4, 4);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(78, 25);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score: 0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 588);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1318, 10);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.Location = new System.Drawing.Point(1320, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 267);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Location = new System.Drawing.Point(12, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 267);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.Location = new System.Drawing.Point(113, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1217, 10);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Blue;
            this.pictureBox5.Location = new System.Drawing.Point(1320, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 269);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "wall";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Blue;
            this.pictureBox6.Location = new System.Drawing.Point(12, 32);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 249);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "wall";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Blue;
            this.pictureBox7.Location = new System.Drawing.Point(74, 271);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(396, 10);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "wall";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Blue;
            this.pictureBox8.Location = new System.Drawing.Point(865, 271);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(396, 10);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "wall";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Blue;
            this.pictureBox9.Location = new System.Drawing.Point(468, 516);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(396, 10);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "wall";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Blue;
            this.pictureBox10.Location = new System.Drawing.Point(468, 76);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(396, 10);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "wall";
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Blue;
            this.pictureBox11.Location = new System.Drawing.Point(932, 76);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(329, 10);
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "wall";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Blue;
            this.pictureBox12.Location = new System.Drawing.Point(865, 140);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(396, 18);
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "wall";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Blue;
            this.pictureBox13.Location = new System.Drawing.Point(760, 148);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 38);
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "wall";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Blue;
            this.pictureBox14.Location = new System.Drawing.Point(526, 148);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(43, 38);
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "wall";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Blue;
            this.pictureBox15.Location = new System.Drawing.Point(865, 331);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(396, 10);
            this.pictureBox15.TabIndex = 15;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "wall";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Blue;
            this.pictureBox16.Location = new System.Drawing.Point(74, 331);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(396, 10);
            this.pictureBox16.TabIndex = 16;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "wall";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Blue;
            this.pictureBox17.Location = new System.Drawing.Point(74, 140);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(396, 18);
            this.pictureBox17.TabIndex = 17;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "wall";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Blue;
            this.pictureBox18.Location = new System.Drawing.Point(74, 208);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(396, 10);
            this.pictureBox18.TabIndex = 18;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "wall";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Blue;
            this.pictureBox19.Location = new System.Drawing.Point(865, 208);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(396, 10);
            this.pictureBox19.TabIndex = 19;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "wall";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Blue;
            this.pictureBox20.Location = new System.Drawing.Point(74, 393);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(325, 133);
            this.pictureBox20.TabIndex = 20;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "wall";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Blue;
            this.pictureBox21.Location = new System.Drawing.Point(468, 393);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(396, 77);
            this.pictureBox21.TabIndex = 21;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "wall";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Blue;
            this.pictureBox22.Location = new System.Drawing.Point(932, 393);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(329, 133);
            this.pictureBox22.TabIndex = 22;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "wall";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Blue;
            this.pictureBox23.Location = new System.Drawing.Point(74, 76);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(325, 10);
            this.pictureBox23.TabIndex = 23;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "wall";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Blue;
            this.pictureBox24.Location = new System.Drawing.Point(526, 246);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(259, 95);
            this.pictureBox24.TabIndex = 24;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "wall";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Blue;
            this.pictureBox25.Location = new System.Drawing.Point(526, 140);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(99, 18);
            this.pictureBox25.TabIndex = 25;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "wall";
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Blue;
            this.pictureBox26.Location = new System.Drawing.Point(699, 140);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(86, 18);
            this.pictureBox26.TabIndex = 26;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Tag = "wall";
            // 
            // yellowGhost
            // 
            this.yellowGhost.Image = global::Game.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(589, 187);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 42);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 27;
            this.yellowGhost.TabStop = false;
            this.yellowGhost.Tag = "ghost";
            // 
            // redGhost
            // 
            this.redGhost.Image = global::Game.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(642, 187);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 42);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 28;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = global::Game.Properties.Resources.pink_guy;
            this.pinkGhost.Location = new System.Drawing.Point(699, 187);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 42);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 29;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Orange;
            this.pictureBox31.Location = new System.Drawing.Point(426, 454);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(10, 10);
            this.pictureBox31.TabIndex = 31;
            this.pictureBox31.TabStop = false;
            this.pictureBox31.Tag = "coinScore";
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.Orange;
            this.pictureBox32.Location = new System.Drawing.Point(426, 438);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(10, 10);
            this.pictureBox32.TabIndex = 32;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Tag = "coinScore";
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.Orange;
            this.pictureBox36.Location = new System.Drawing.Point(634, 358);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(10, 10);
            this.pictureBox36.TabIndex = 36;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.Tag = "coinScore";
            // 
            // pictureBox33
            // 
            this.pictureBox33.BackColor = System.Drawing.Color.Orange;
            this.pictureBox33.Location = new System.Drawing.Point(426, 422);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(10, 10);
            this.pictureBox33.TabIndex = 33;
            this.pictureBox33.TabStop = false;
            this.pictureBox33.Tag = "coinScore";
            // 
            // pictureBox34
            // 
            this.pictureBox34.BackColor = System.Drawing.Color.Orange;
            this.pictureBox34.Location = new System.Drawing.Point(426, 406);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(10, 10);
            this.pictureBox34.TabIndex = 34;
            this.pictureBox34.TabStop = false;
            this.pictureBox34.Tag = "coinScore";
            // 
            // pictureBox35
            // 
            this.pictureBox35.BackColor = System.Drawing.Color.Orange;
            this.pictureBox35.Location = new System.Drawing.Point(426, 390);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(10, 10);
            this.pictureBox35.TabIndex = 35;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.Tag = "coinScore";
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.Orange;
            this.pictureBox37.Location = new System.Drawing.Point(426, 473);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(10, 10);
            this.pictureBox37.TabIndex = 42;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Tag = "coinScore";
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.Color.Orange;
            this.pictureBox38.Location = new System.Drawing.Point(426, 489);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(10, 10);
            this.pictureBox38.TabIndex = 41;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Tag = "coinScore";
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.Orange;
            this.pictureBox39.Location = new System.Drawing.Point(426, 505);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(10, 10);
            this.pictureBox39.TabIndex = 40;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Tag = "coinScore";
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.Orange;
            this.pictureBox40.Location = new System.Drawing.Point(426, 521);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(10, 10);
            this.pictureBox40.TabIndex = 39;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.Tag = "coinScore";
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.Orange;
            this.pictureBox41.Location = new System.Drawing.Point(426, 537);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(10, 10);
            this.pictureBox41.TabIndex = 38;
            this.pictureBox41.TabStop = false;
            this.pictureBox41.Tag = "coinScore";
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.Orange;
            this.pictureBox43.Location = new System.Drawing.Point(37, 473);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(10, 10);
            this.pictureBox43.TabIndex = 48;
            this.pictureBox43.TabStop = false;
            this.pictureBox43.Tag = "coinScore";
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.Orange;
            this.pictureBox44.Location = new System.Drawing.Point(37, 489);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(10, 10);
            this.pictureBox44.TabIndex = 47;
            this.pictureBox44.TabStop = false;
            this.pictureBox44.Tag = "coinScore";
            // 
            // pictureBox45
            // 
            this.pictureBox45.BackColor = System.Drawing.Color.Orange;
            this.pictureBox45.Location = new System.Drawing.Point(37, 505);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(10, 10);
            this.pictureBox45.TabIndex = 46;
            this.pictureBox45.TabStop = false;
            this.pictureBox45.Tag = "coinScore";
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackColor = System.Drawing.Color.Orange;
            this.pictureBox46.Location = new System.Drawing.Point(37, 521);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(10, 10);
            this.pictureBox46.TabIndex = 45;
            this.pictureBox46.TabStop = false;
            this.pictureBox46.Tag = "coinScore";
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackColor = System.Drawing.Color.Orange;
            this.pictureBox49.Location = new System.Drawing.Point(37, 374);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(10, 10);
            this.pictureBox49.TabIndex = 54;
            this.pictureBox49.TabStop = false;
            this.pictureBox49.Tag = "coinScore";
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackColor = System.Drawing.Color.Orange;
            this.pictureBox50.Location = new System.Drawing.Point(37, 390);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(10, 10);
            this.pictureBox50.TabIndex = 53;
            this.pictureBox50.TabStop = false;
            this.pictureBox50.Tag = "coinScore";
            // 
            // pictureBox51
            // 
            this.pictureBox51.BackColor = System.Drawing.Color.Orange;
            this.pictureBox51.Location = new System.Drawing.Point(37, 406);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(10, 10);
            this.pictureBox51.TabIndex = 52;
            this.pictureBox51.TabStop = false;
            this.pictureBox51.Tag = "coinScore";
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.Color.Orange;
            this.pictureBox52.Location = new System.Drawing.Point(37, 422);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(10, 10);
            this.pictureBox52.TabIndex = 51;
            this.pictureBox52.TabStop = false;
            this.pictureBox52.Tag = "coinScore";
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackColor = System.Drawing.Color.Orange;
            this.pictureBox53.Location = new System.Drawing.Point(37, 438);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(10, 10);
            this.pictureBox53.TabIndex = 50;
            this.pictureBox53.TabStop = false;
            this.pictureBox53.Tag = "coinScore";
            // 
            // pictureBox54
            // 
            this.pictureBox54.BackColor = System.Drawing.Color.Orange;
            this.pictureBox54.Location = new System.Drawing.Point(37, 454);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(10, 10);
            this.pictureBox54.TabIndex = 49;
            this.pictureBox54.TabStop = false;
            this.pictureBox54.Tag = "coinScore";
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackColor = System.Drawing.Color.Orange;
            this.pictureBox55.Location = new System.Drawing.Point(37, 278);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(10, 10);
            this.pictureBox55.TabIndex = 60;
            this.pictureBox55.TabStop = false;
            this.pictureBox55.Tag = "coinScore";
            // 
            // pictureBox56
            // 
            this.pictureBox56.BackColor = System.Drawing.Color.Orange;
            this.pictureBox56.Location = new System.Drawing.Point(37, 294);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(10, 10);
            this.pictureBox56.TabIndex = 59;
            this.pictureBox56.TabStop = false;
            this.pictureBox56.Tag = "coinScore";
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackColor = System.Drawing.Color.Orange;
            this.pictureBox57.Location = new System.Drawing.Point(37, 310);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(10, 10);
            this.pictureBox57.TabIndex = 58;
            this.pictureBox57.TabStop = false;
            this.pictureBox57.Tag = "coinScore";
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackColor = System.Drawing.Color.Orange;
            this.pictureBox58.Location = new System.Drawing.Point(37, 326);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(10, 10);
            this.pictureBox58.TabIndex = 57;
            this.pictureBox58.TabStop = false;
            this.pictureBox58.Tag = "coinScore";
            // 
            // pictureBox59
            // 
            this.pictureBox59.BackColor = System.Drawing.Color.Orange;
            this.pictureBox59.Location = new System.Drawing.Point(37, 342);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(10, 10);
            this.pictureBox59.TabIndex = 56;
            this.pictureBox59.TabStop = false;
            this.pictureBox59.Tag = "coinScore";
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackColor = System.Drawing.Color.Orange;
            this.pictureBox60.Location = new System.Drawing.Point(37, 358);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(10, 10);
            this.pictureBox60.TabIndex = 55;
            this.pictureBox60.TabStop = false;
            this.pictureBox60.Tag = "coinScore";
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackColor = System.Drawing.Color.Orange;
            this.pictureBox61.Location = new System.Drawing.Point(816, 96);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(10, 10);
            this.pictureBox61.TabIndex = 78;
            this.pictureBox61.TabStop = false;
            this.pictureBox61.Tag = "coinScore";
            // 
            // pictureBox62
            // 
            this.pictureBox62.BackColor = System.Drawing.Color.Orange;
            this.pictureBox62.Location = new System.Drawing.Point(816, 112);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(10, 10);
            this.pictureBox62.TabIndex = 77;
            this.pictureBox62.TabStop = false;
            this.pictureBox62.Tag = "coinScore";
            // 
            // pictureBox63
            // 
            this.pictureBox63.BackColor = System.Drawing.Color.Orange;
            this.pictureBox63.Location = new System.Drawing.Point(816, 128);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(10, 10);
            this.pictureBox63.TabIndex = 76;
            this.pictureBox63.TabStop = false;
            this.pictureBox63.Tag = "coinScore";
            // 
            // pictureBox64
            // 
            this.pictureBox64.BackColor = System.Drawing.Color.Orange;
            this.pictureBox64.Location = new System.Drawing.Point(816, 144);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(10, 10);
            this.pictureBox64.TabIndex = 75;
            this.pictureBox64.TabStop = false;
            this.pictureBox64.Tag = "coinScore";
            // 
            // pictureBox65
            // 
            this.pictureBox65.BackColor = System.Drawing.Color.Orange;
            this.pictureBox65.Location = new System.Drawing.Point(816, 160);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(10, 10);
            this.pictureBox65.TabIndex = 74;
            this.pictureBox65.TabStop = false;
            this.pictureBox65.Tag = "coinScore";
            // 
            // pictureBox66
            // 
            this.pictureBox66.BackColor = System.Drawing.Color.Orange;
            this.pictureBox66.Location = new System.Drawing.Point(816, 176);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(10, 10);
            this.pictureBox66.TabIndex = 73;
            this.pictureBox66.TabStop = false;
            this.pictureBox66.Tag = "coinScore";
            // 
            // pictureBox67
            // 
            this.pictureBox67.BackColor = System.Drawing.Color.Orange;
            this.pictureBox67.Location = new System.Drawing.Point(816, 192);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(10, 10);
            this.pictureBox67.TabIndex = 72;
            this.pictureBox67.TabStop = false;
            this.pictureBox67.Tag = "coinScore";
            // 
            // pictureBox68
            // 
            this.pictureBox68.BackColor = System.Drawing.Color.Orange;
            this.pictureBox68.Location = new System.Drawing.Point(816, 208);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(10, 10);
            this.pictureBox68.TabIndex = 71;
            this.pictureBox68.TabStop = false;
            this.pictureBox68.Tag = "coinScore";
            // 
            // pictureBox69
            // 
            this.pictureBox69.BackColor = System.Drawing.Color.Orange;
            this.pictureBox69.Location = new System.Drawing.Point(816, 224);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(10, 10);
            this.pictureBox69.TabIndex = 70;
            this.pictureBox69.TabStop = false;
            this.pictureBox69.Tag = "coinScore";
            // 
            // pictureBox70
            // 
            this.pictureBox70.BackColor = System.Drawing.Color.Orange;
            this.pictureBox70.Location = new System.Drawing.Point(816, 240);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(10, 10);
            this.pictureBox70.TabIndex = 69;
            this.pictureBox70.TabStop = false;
            this.pictureBox70.Tag = "coinScore";
            // 
            // pictureBox71
            // 
            this.pictureBox71.BackColor = System.Drawing.Color.Orange;
            this.pictureBox71.Location = new System.Drawing.Point(897, 516);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(10, 10);
            this.pictureBox71.TabIndex = 68;
            this.pictureBox71.TabStop = false;
            this.pictureBox71.Tag = "coinScore";
            // 
            // pictureBox72
            // 
            this.pictureBox72.BackColor = System.Drawing.Color.Orange;
            this.pictureBox72.Location = new System.Drawing.Point(816, 272);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(10, 10);
            this.pictureBox72.TabIndex = 67;
            this.pictureBox72.TabStop = false;
            this.pictureBox72.Tag = "coinScore";
            // 
            // pictureBox73
            // 
            this.pictureBox73.BackColor = System.Drawing.Color.Orange;
            this.pictureBox73.Location = new System.Drawing.Point(894, 486);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(10, 10);
            this.pictureBox73.TabIndex = 66;
            this.pictureBox73.TabStop = false;
            this.pictureBox73.Tag = "coinScore";
            // 
            // pictureBox74
            // 
            this.pictureBox74.BackColor = System.Drawing.Color.Orange;
            this.pictureBox74.Location = new System.Drawing.Point(816, 307);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(10, 10);
            this.pictureBox74.TabIndex = 65;
            this.pictureBox74.TabStop = false;
            this.pictureBox74.Tag = "coinScore";
            // 
            // pictureBox75
            // 
            this.pictureBox75.BackColor = System.Drawing.Color.Orange;
            this.pictureBox75.Location = new System.Drawing.Point(894, 454);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(10, 10);
            this.pictureBox75.TabIndex = 64;
            this.pictureBox75.TabStop = false;
            this.pictureBox75.Tag = "coinScore";
            // 
            // pictureBox76
            // 
            this.pictureBox76.BackColor = System.Drawing.Color.Orange;
            this.pictureBox76.Location = new System.Drawing.Point(816, 339);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(10, 10);
            this.pictureBox76.TabIndex = 63;
            this.pictureBox76.TabStop = false;
            this.pictureBox76.Tag = "coinScore";
            // 
            // pictureBox77
            // 
            this.pictureBox77.BackColor = System.Drawing.Color.Orange;
            this.pictureBox77.Location = new System.Drawing.Point(894, 422);
            this.pictureBox77.Name = "pictureBox77";
            this.pictureBox77.Size = new System.Drawing.Size(10, 10);
            this.pictureBox77.TabIndex = 62;
            this.pictureBox77.TabStop = false;
            this.pictureBox77.Tag = "coinScore";
            // 
            // pictureBox78
            // 
            this.pictureBox78.BackColor = System.Drawing.Color.Orange;
            this.pictureBox78.Location = new System.Drawing.Point(894, 390);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(10, 10);
            this.pictureBox78.TabIndex = 61;
            this.pictureBox78.TabStop = false;
            this.pictureBox78.Tag = "coinScore";
            // 
            // pictureBox79
            // 
            this.pictureBox79.BackColor = System.Drawing.Color.Orange;
            this.pictureBox79.Location = new System.Drawing.Point(1227, 42);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(10, 10);
            this.pictureBox79.TabIndex = 96;
            this.pictureBox79.TabStop = false;
            this.pictureBox79.Tag = "coinScore";
            // 
            // pictureBox80
            // 
            this.pictureBox80.BackColor = System.Drawing.Color.Orange;
            this.pictureBox80.Location = new System.Drawing.Point(1249, 42);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(10, 10);
            this.pictureBox80.TabIndex = 95;
            this.pictureBox80.TabStop = false;
            this.pictureBox80.Tag = "coinScore";
            // 
            // pictureBox81
            // 
            this.pictureBox81.BackColor = System.Drawing.Color.Orange;
            this.pictureBox81.Location = new System.Drawing.Point(1289, 64);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(10, 10);
            this.pictureBox81.TabIndex = 94;
            this.pictureBox81.TabStop = false;
            this.pictureBox81.Tag = "coinScore";
            // 
            // pictureBox82
            // 
            this.pictureBox82.BackColor = System.Drawing.Color.Orange;
            this.pictureBox82.Location = new System.Drawing.Point(1289, 80);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(10, 10);
            this.pictureBox82.TabIndex = 93;
            this.pictureBox82.TabStop = false;
            this.pictureBox82.Tag = "coinScore";
            // 
            // pictureBox83
            // 
            this.pictureBox83.BackColor = System.Drawing.Color.Orange;
            this.pictureBox83.Location = new System.Drawing.Point(1289, 96);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(10, 10);
            this.pictureBox83.TabIndex = 92;
            this.pictureBox83.TabStop = false;
            this.pictureBox83.Tag = "coinScore";
            // 
            // pictureBox84
            // 
            this.pictureBox84.BackColor = System.Drawing.Color.Orange;
            this.pictureBox84.Location = new System.Drawing.Point(1289, 112);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(10, 10);
            this.pictureBox84.TabIndex = 91;
            this.pictureBox84.TabStop = false;
            this.pictureBox84.Tag = "coinScore";
            // 
            // pictureBox85
            // 
            this.pictureBox85.BackColor = System.Drawing.Color.Orange;
            this.pictureBox85.Location = new System.Drawing.Point(1289, 128);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(10, 10);
            this.pictureBox85.TabIndex = 90;
            this.pictureBox85.TabStop = false;
            this.pictureBox85.Tag = "coinScore";
            // 
            // pictureBox86
            // 
            this.pictureBox86.BackColor = System.Drawing.Color.Orange;
            this.pictureBox86.Location = new System.Drawing.Point(1289, 144);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(10, 10);
            this.pictureBox86.TabIndex = 89;
            this.pictureBox86.TabStop = false;
            this.pictureBox86.Tag = "coinScore";
            // 
            // pictureBox87
            // 
            this.pictureBox87.BackColor = System.Drawing.Color.Orange;
            this.pictureBox87.Location = new System.Drawing.Point(1289, 160);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(10, 10);
            this.pictureBox87.TabIndex = 88;
            this.pictureBox87.TabStop = false;
            this.pictureBox87.Tag = "coinScore";
            // 
            // pictureBox88
            // 
            this.pictureBox88.BackColor = System.Drawing.Color.Orange;
            this.pictureBox88.Location = new System.Drawing.Point(1289, 176);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(10, 10);
            this.pictureBox88.TabIndex = 87;
            this.pictureBox88.TabStop = false;
            this.pictureBox88.Tag = "coinScore";
            // 
            // pictureBox89
            // 
            this.pictureBox89.BackColor = System.Drawing.Color.Orange;
            this.pictureBox89.Location = new System.Drawing.Point(1289, 192);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(10, 10);
            this.pictureBox89.TabIndex = 86;
            this.pictureBox89.TabStop = false;
            this.pictureBox89.Tag = "coinScore";
            // 
            // pictureBox90
            // 
            this.pictureBox90.BackColor = System.Drawing.Color.Orange;
            this.pictureBox90.Location = new System.Drawing.Point(1289, 208);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(10, 10);
            this.pictureBox90.TabIndex = 85;
            this.pictureBox90.TabStop = false;
            this.pictureBox90.Tag = "coinScore";
            // 
            // pictureBox91
            // 
            this.pictureBox91.BackColor = System.Drawing.Color.Orange;
            this.pictureBox91.Location = new System.Drawing.Point(1289, 227);
            this.pictureBox91.Name = "pictureBox91";
            this.pictureBox91.Size = new System.Drawing.Size(10, 10);
            this.pictureBox91.TabIndex = 84;
            this.pictureBox91.TabStop = false;
            this.pictureBox91.Tag = "coinScore";
            // 
            // pictureBox92
            // 
            this.pictureBox92.BackColor = System.Drawing.Color.Orange;
            this.pictureBox92.Location = new System.Drawing.Point(1289, 243);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(10, 10);
            this.pictureBox92.TabIndex = 83;
            this.pictureBox92.TabStop = false;
            this.pictureBox92.Tag = "coinScore";
            // 
            // pictureBox93
            // 
            this.pictureBox93.BackColor = System.Drawing.Color.Orange;
            this.pictureBox93.Location = new System.Drawing.Point(1289, 259);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(10, 10);
            this.pictureBox93.TabIndex = 82;
            this.pictureBox93.TabStop = false;
            this.pictureBox93.Tag = "coinScore";
            // 
            // pictureBox94
            // 
            this.pictureBox94.BackColor = System.Drawing.Color.Orange;
            this.pictureBox94.Location = new System.Drawing.Point(1289, 275);
            this.pictureBox94.Name = "pictureBox94";
            this.pictureBox94.Size = new System.Drawing.Size(10, 10);
            this.pictureBox94.TabIndex = 81;
            this.pictureBox94.TabStop = false;
            this.pictureBox94.Tag = "coinScore";
            // 
            // pictureBox95
            // 
            this.pictureBox95.BackColor = System.Drawing.Color.Orange;
            this.pictureBox95.Location = new System.Drawing.Point(1289, 291);
            this.pictureBox95.Name = "pictureBox95";
            this.pictureBox95.Size = new System.Drawing.Size(10, 10);
            this.pictureBox95.TabIndex = 80;
            this.pictureBox95.TabStop = false;
            this.pictureBox95.Tag = "coinScore";
            // 
            // pictureBox96
            // 
            this.pictureBox96.BackColor = System.Drawing.Color.Orange;
            this.pictureBox96.Location = new System.Drawing.Point(1289, 307);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(10, 10);
            this.pictureBox96.TabIndex = 79;
            this.pictureBox96.TabStop = false;
            this.pictureBox96.Tag = "coinScore";
            // 
            // pictureBox97
            // 
            this.pictureBox97.BackColor = System.Drawing.Color.Orange;
            this.pictureBox97.Location = new System.Drawing.Point(1289, 326);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(10, 10);
            this.pictureBox97.TabIndex = 114;
            this.pictureBox97.TabStop = false;
            this.pictureBox97.Tag = "coinScore";
            // 
            // pictureBox98
            // 
            this.pictureBox98.BackColor = System.Drawing.Color.Orange;
            this.pictureBox98.Location = new System.Drawing.Point(1289, 342);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(10, 10);
            this.pictureBox98.TabIndex = 113;
            this.pictureBox98.TabStop = false;
            this.pictureBox98.Tag = "coinScore";
            // 
            // pictureBox99
            // 
            this.pictureBox99.BackColor = System.Drawing.Color.Orange;
            this.pictureBox99.Location = new System.Drawing.Point(1289, 358);
            this.pictureBox99.Name = "pictureBox99";
            this.pictureBox99.Size = new System.Drawing.Size(10, 10);
            this.pictureBox99.TabIndex = 112;
            this.pictureBox99.TabStop = false;
            this.pictureBox99.Tag = "coinScore";
            // 
            // pictureBox100
            // 
            this.pictureBox100.BackColor = System.Drawing.Color.Orange;
            this.pictureBox100.Location = new System.Drawing.Point(1289, 374);
            this.pictureBox100.Name = "pictureBox100";
            this.pictureBox100.Size = new System.Drawing.Size(10, 10);
            this.pictureBox100.TabIndex = 111;
            this.pictureBox100.TabStop = false;
            this.pictureBox100.Tag = "coinScore";
            // 
            // pictureBox101
            // 
            this.pictureBox101.BackColor = System.Drawing.Color.Orange;
            this.pictureBox101.Location = new System.Drawing.Point(1289, 390);
            this.pictureBox101.Name = "pictureBox101";
            this.pictureBox101.Size = new System.Drawing.Size(10, 10);
            this.pictureBox101.TabIndex = 110;
            this.pictureBox101.TabStop = false;
            this.pictureBox101.Tag = "coinScore";
            // 
            // pictureBox102
            // 
            this.pictureBox102.BackColor = System.Drawing.Color.Orange;
            this.pictureBox102.Location = new System.Drawing.Point(1289, 406);
            this.pictureBox102.Name = "pictureBox102";
            this.pictureBox102.Size = new System.Drawing.Size(10, 10);
            this.pictureBox102.TabIndex = 109;
            this.pictureBox102.TabStop = false;
            this.pictureBox102.Tag = "coinScore";
            // 
            // pictureBox103
            // 
            this.pictureBox103.BackColor = System.Drawing.Color.Orange;
            this.pictureBox103.Location = new System.Drawing.Point(1289, 422);
            this.pictureBox103.Name = "pictureBox103";
            this.pictureBox103.Size = new System.Drawing.Size(10, 10);
            this.pictureBox103.TabIndex = 108;
            this.pictureBox103.TabStop = false;
            this.pictureBox103.Tag = "coinScore";
            // 
            // pictureBox104
            // 
            this.pictureBox104.BackColor = System.Drawing.Color.Orange;
            this.pictureBox104.Location = new System.Drawing.Point(1289, 438);
            this.pictureBox104.Name = "pictureBox104";
            this.pictureBox104.Size = new System.Drawing.Size(10, 10);
            this.pictureBox104.TabIndex = 107;
            this.pictureBox104.TabStop = false;
            this.pictureBox104.Tag = "coinScore";
            // 
            // pictureBox105
            // 
            this.pictureBox105.BackColor = System.Drawing.Color.Orange;
            this.pictureBox105.Location = new System.Drawing.Point(1289, 454);
            this.pictureBox105.Name = "pictureBox105";
            this.pictureBox105.Size = new System.Drawing.Size(10, 10);
            this.pictureBox105.TabIndex = 106;
            this.pictureBox105.TabStop = false;
            this.pictureBox105.Tag = "coinScore";
            // 
            // pictureBox106
            // 
            this.pictureBox106.BackColor = System.Drawing.Color.Orange;
            this.pictureBox106.Location = new System.Drawing.Point(1289, 470);
            this.pictureBox106.Name = "pictureBox106";
            this.pictureBox106.Size = new System.Drawing.Size(10, 10);
            this.pictureBox106.TabIndex = 105;
            this.pictureBox106.TabStop = false;
            this.pictureBox106.Tag = "coinScore";
            // 
            // pictureBox107
            // 
            this.pictureBox107.BackColor = System.Drawing.Color.Orange;
            this.pictureBox107.Location = new System.Drawing.Point(1289, 486);
            this.pictureBox107.Name = "pictureBox107";
            this.pictureBox107.Size = new System.Drawing.Size(10, 10);
            this.pictureBox107.TabIndex = 104;
            this.pictureBox107.TabStop = false;
            this.pictureBox107.Tag = "coinScore";
            // 
            // pictureBox108
            // 
            this.pictureBox108.BackColor = System.Drawing.Color.Orange;
            this.pictureBox108.Location = new System.Drawing.Point(1289, 502);
            this.pictureBox108.Name = "pictureBox108";
            this.pictureBox108.Size = new System.Drawing.Size(10, 10);
            this.pictureBox108.TabIndex = 103;
            this.pictureBox108.TabStop = false;
            this.pictureBox108.Tag = "coinScore";
            // 
            // pictureBox109
            // 
            this.pictureBox109.BackColor = System.Drawing.Color.Orange;
            this.pictureBox109.Location = new System.Drawing.Point(1289, 521);
            this.pictureBox109.Name = "pictureBox109";
            this.pictureBox109.Size = new System.Drawing.Size(10, 10);
            this.pictureBox109.TabIndex = 102;
            this.pictureBox109.TabStop = false;
            this.pictureBox109.Tag = "coinScore";
            // 
            // pictureBox110
            // 
            this.pictureBox110.BackColor = System.Drawing.Color.Orange;
            this.pictureBox110.Location = new System.Drawing.Point(1154, 553);
            this.pictureBox110.Name = "pictureBox110";
            this.pictureBox110.Size = new System.Drawing.Size(10, 10);
            this.pictureBox110.TabIndex = 101;
            this.pictureBox110.TabStop = false;
            this.pictureBox110.Tag = "coinScore";
            // 
            // pictureBox111
            // 
            this.pictureBox111.BackColor = System.Drawing.Color.Orange;
            this.pictureBox111.Location = new System.Drawing.Point(1179, 553);
            this.pictureBox111.Name = "pictureBox111";
            this.pictureBox111.Size = new System.Drawing.Size(10, 10);
            this.pictureBox111.TabIndex = 100;
            this.pictureBox111.TabStop = false;
            this.pictureBox111.Tag = "coinScore";
            // 
            // pictureBox112
            // 
            this.pictureBox112.BackColor = System.Drawing.Color.Orange;
            this.pictureBox112.Location = new System.Drawing.Point(1204, 553);
            this.pictureBox112.Name = "pictureBox112";
            this.pictureBox112.Size = new System.Drawing.Size(10, 10);
            this.pictureBox112.TabIndex = 99;
            this.pictureBox112.TabStop = false;
            this.pictureBox112.Tag = "coinScore";
            // 
            // pictureBox113
            // 
            this.pictureBox113.BackColor = System.Drawing.Color.Orange;
            this.pictureBox113.Location = new System.Drawing.Point(1229, 553);
            this.pictureBox113.Name = "pictureBox113";
            this.pictureBox113.Size = new System.Drawing.Size(10, 10);
            this.pictureBox113.TabIndex = 98;
            this.pictureBox113.TabStop = false;
            this.pictureBox113.Tag = "coinScore";
            // 
            // pictureBox114
            // 
            this.pictureBox114.BackColor = System.Drawing.Color.Orange;
            this.pictureBox114.Location = new System.Drawing.Point(1251, 553);
            this.pictureBox114.Name = "pictureBox114";
            this.pictureBox114.Size = new System.Drawing.Size(10, 10);
            this.pictureBox114.TabIndex = 97;
            this.pictureBox114.TabStop = false;
            this.pictureBox114.Tag = "coinScore";
            // 
            // pictureBox115
            // 
            this.pictureBox115.BackColor = System.Drawing.Color.Orange;
            this.pictureBox115.Location = new System.Drawing.Point(1034, 553);
            this.pictureBox115.Name = "pictureBox115";
            this.pictureBox115.Size = new System.Drawing.Size(10, 10);
            this.pictureBox115.TabIndex = 119;
            this.pictureBox115.TabStop = false;
            this.pictureBox115.Tag = "coinScore";
            // 
            // pictureBox116
            // 
            this.pictureBox116.BackColor = System.Drawing.Color.Orange;
            this.pictureBox116.Location = new System.Drawing.Point(1059, 553);
            this.pictureBox116.Name = "pictureBox116";
            this.pictureBox116.Size = new System.Drawing.Size(10, 10);
            this.pictureBox116.TabIndex = 118;
            this.pictureBox116.TabStop = false;
            this.pictureBox116.Tag = "coinScore";
            // 
            // pictureBox117
            // 
            this.pictureBox117.BackColor = System.Drawing.Color.Orange;
            this.pictureBox117.Location = new System.Drawing.Point(1084, 553);
            this.pictureBox117.Name = "pictureBox117";
            this.pictureBox117.Size = new System.Drawing.Size(10, 10);
            this.pictureBox117.TabIndex = 117;
            this.pictureBox117.TabStop = false;
            this.pictureBox117.Tag = "coinScore";
            // 
            // pictureBox118
            // 
            this.pictureBox118.BackColor = System.Drawing.Color.Orange;
            this.pictureBox118.Location = new System.Drawing.Point(1109, 553);
            this.pictureBox118.Name = "pictureBox118";
            this.pictureBox118.Size = new System.Drawing.Size(10, 10);
            this.pictureBox118.TabIndex = 116;
            this.pictureBox118.TabStop = false;
            this.pictureBox118.Tag = "coinScore";
            // 
            // pictureBox119
            // 
            this.pictureBox119.BackColor = System.Drawing.Color.Orange;
            this.pictureBox119.Location = new System.Drawing.Point(1131, 553);
            this.pictureBox119.Name = "pictureBox119";
            this.pictureBox119.Size = new System.Drawing.Size(10, 10);
            this.pictureBox119.TabIndex = 115;
            this.pictureBox119.TabStop = false;
            this.pictureBox119.Tag = "coinScore";
            // 
            // pictureBox120
            // 
            this.pictureBox120.BackColor = System.Drawing.Color.Orange;
            this.pictureBox120.Location = new System.Drawing.Point(797, 553);
            this.pictureBox120.Name = "pictureBox120";
            this.pictureBox120.Size = new System.Drawing.Size(10, 10);
            this.pictureBox120.TabIndex = 129;
            this.pictureBox120.TabStop = false;
            this.pictureBox120.Tag = "coinScore";
            // 
            // pictureBox121
            // 
            this.pictureBox121.BackColor = System.Drawing.Color.Orange;
            this.pictureBox121.Location = new System.Drawing.Point(822, 553);
            this.pictureBox121.Name = "pictureBox121";
            this.pictureBox121.Size = new System.Drawing.Size(10, 10);
            this.pictureBox121.TabIndex = 128;
            this.pictureBox121.TabStop = false;
            this.pictureBox121.Tag = "coinScore";
            // 
            // pictureBox122
            // 
            this.pictureBox122.BackColor = System.Drawing.Color.Orange;
            this.pictureBox122.Location = new System.Drawing.Point(847, 553);
            this.pictureBox122.Name = "pictureBox122";
            this.pictureBox122.Size = new System.Drawing.Size(10, 10);
            this.pictureBox122.TabIndex = 127;
            this.pictureBox122.TabStop = false;
            this.pictureBox122.Tag = "coinScore";
            // 
            // pictureBox123
            // 
            this.pictureBox123.BackColor = System.Drawing.Color.Orange;
            this.pictureBox123.Location = new System.Drawing.Point(872, 553);
            this.pictureBox123.Name = "pictureBox123";
            this.pictureBox123.Size = new System.Drawing.Size(10, 10);
            this.pictureBox123.TabIndex = 126;
            this.pictureBox123.TabStop = false;
            this.pictureBox123.Tag = "coinScore";
            // 
            // pictureBox124
            // 
            this.pictureBox124.BackColor = System.Drawing.Color.Orange;
            this.pictureBox124.Location = new System.Drawing.Point(894, 553);
            this.pictureBox124.Name = "pictureBox124";
            this.pictureBox124.Size = new System.Drawing.Size(10, 10);
            this.pictureBox124.TabIndex = 125;
            this.pictureBox124.TabStop = false;
            this.pictureBox124.Tag = "coinScore";
            // 
            // pictureBox125
            // 
            this.pictureBox125.BackColor = System.Drawing.Color.Orange;
            this.pictureBox125.Location = new System.Drawing.Point(917, 553);
            this.pictureBox125.Name = "pictureBox125";
            this.pictureBox125.Size = new System.Drawing.Size(10, 10);
            this.pictureBox125.TabIndex = 124;
            this.pictureBox125.TabStop = false;
            this.pictureBox125.Tag = "coinScore";
            // 
            // pictureBox126
            // 
            this.pictureBox126.BackColor = System.Drawing.Color.Orange;
            this.pictureBox126.Location = new System.Drawing.Point(942, 553);
            this.pictureBox126.Name = "pictureBox126";
            this.pictureBox126.Size = new System.Drawing.Size(10, 10);
            this.pictureBox126.TabIndex = 123;
            this.pictureBox126.TabStop = false;
            this.pictureBox126.Tag = "coinScore";
            // 
            // pictureBox127
            // 
            this.pictureBox127.BackColor = System.Drawing.Color.Orange;
            this.pictureBox127.Location = new System.Drawing.Point(967, 553);
            this.pictureBox127.Name = "pictureBox127";
            this.pictureBox127.Size = new System.Drawing.Size(10, 10);
            this.pictureBox127.TabIndex = 122;
            this.pictureBox127.TabStop = false;
            this.pictureBox127.Tag = "coinScore";
            // 
            // pictureBox128
            // 
            this.pictureBox128.BackColor = System.Drawing.Color.Orange;
            this.pictureBox128.Location = new System.Drawing.Point(992, 553);
            this.pictureBox128.Name = "pictureBox128";
            this.pictureBox128.Size = new System.Drawing.Size(10, 10);
            this.pictureBox128.TabIndex = 121;
            this.pictureBox128.TabStop = false;
            this.pictureBox128.Tag = "coinScore";
            // 
            // pictureBox129
            // 
            this.pictureBox129.BackColor = System.Drawing.Color.Orange;
            this.pictureBox129.Location = new System.Drawing.Point(1014, 553);
            this.pictureBox129.Name = "pictureBox129";
            this.pictureBox129.Size = new System.Drawing.Size(10, 10);
            this.pictureBox129.TabIndex = 120;
            this.pictureBox129.TabStop = false;
            this.pictureBox129.Tag = "coinScore";
            // 
            // pictureBox130
            // 
            this.pictureBox130.BackColor = System.Drawing.Color.Orange;
            this.pictureBox130.Location = new System.Drawing.Point(63, 553);
            this.pictureBox130.Name = "pictureBox130";
            this.pictureBox130.Size = new System.Drawing.Size(10, 10);
            this.pictureBox130.TabIndex = 149;
            this.pictureBox130.TabStop = false;
            this.pictureBox130.Tag = "coinScore";
            // 
            // pictureBox131
            // 
            this.pictureBox131.BackColor = System.Drawing.Color.Orange;
            this.pictureBox131.Location = new System.Drawing.Point(88, 553);
            this.pictureBox131.Name = "pictureBox131";
            this.pictureBox131.Size = new System.Drawing.Size(10, 10);
            this.pictureBox131.TabIndex = 148;
            this.pictureBox131.TabStop = false;
            this.pictureBox131.Tag = "coinScore";
            // 
            // pictureBox132
            // 
            this.pictureBox132.BackColor = System.Drawing.Color.Orange;
            this.pictureBox132.Location = new System.Drawing.Point(113, 553);
            this.pictureBox132.Name = "pictureBox132";
            this.pictureBox132.Size = new System.Drawing.Size(10, 10);
            this.pictureBox132.TabIndex = 147;
            this.pictureBox132.TabStop = false;
            this.pictureBox132.Tag = "coinScore";
            // 
            // pictureBox133
            // 
            this.pictureBox133.BackColor = System.Drawing.Color.Orange;
            this.pictureBox133.Location = new System.Drawing.Point(138, 553);
            this.pictureBox133.Name = "pictureBox133";
            this.pictureBox133.Size = new System.Drawing.Size(10, 10);
            this.pictureBox133.TabIndex = 146;
            this.pictureBox133.TabStop = false;
            this.pictureBox133.Tag = "coinScore";
            // 
            // pictureBox134
            // 
            this.pictureBox134.BackColor = System.Drawing.Color.Orange;
            this.pictureBox134.Location = new System.Drawing.Point(160, 553);
            this.pictureBox134.Name = "pictureBox134";
            this.pictureBox134.Size = new System.Drawing.Size(10, 10);
            this.pictureBox134.TabIndex = 145;
            this.pictureBox134.TabStop = false;
            this.pictureBox134.Tag = "coinScore";
            // 
            // pictureBox135
            // 
            this.pictureBox135.BackColor = System.Drawing.Color.Orange;
            this.pictureBox135.Location = new System.Drawing.Point(183, 553);
            this.pictureBox135.Name = "pictureBox135";
            this.pictureBox135.Size = new System.Drawing.Size(10, 10);
            this.pictureBox135.TabIndex = 144;
            this.pictureBox135.TabStop = false;
            this.pictureBox135.Tag = "coinScore";
            // 
            // pictureBox136
            // 
            this.pictureBox136.BackColor = System.Drawing.Color.Orange;
            this.pictureBox136.Location = new System.Drawing.Point(208, 553);
            this.pictureBox136.Name = "pictureBox136";
            this.pictureBox136.Size = new System.Drawing.Size(10, 10);
            this.pictureBox136.TabIndex = 143;
            this.pictureBox136.TabStop = false;
            this.pictureBox136.Tag = "coinScore";
            // 
            // pictureBox137
            // 
            this.pictureBox137.BackColor = System.Drawing.Color.Orange;
            this.pictureBox137.Location = new System.Drawing.Point(233, 553);
            this.pictureBox137.Name = "pictureBox137";
            this.pictureBox137.Size = new System.Drawing.Size(10, 10);
            this.pictureBox137.TabIndex = 142;
            this.pictureBox137.TabStop = false;
            this.pictureBox137.Tag = "coinScore";
            // 
            // pictureBox138
            // 
            this.pictureBox138.BackColor = System.Drawing.Color.Orange;
            this.pictureBox138.Location = new System.Drawing.Point(258, 553);
            this.pictureBox138.Name = "pictureBox138";
            this.pictureBox138.Size = new System.Drawing.Size(10, 10);
            this.pictureBox138.TabIndex = 141;
            this.pictureBox138.TabStop = false;
            this.pictureBox138.Tag = "coinScore";
            // 
            // pictureBox139
            // 
            this.pictureBox139.BackColor = System.Drawing.Color.Orange;
            this.pictureBox139.Location = new System.Drawing.Point(280, 553);
            this.pictureBox139.Name = "pictureBox139";
            this.pictureBox139.Size = new System.Drawing.Size(10, 10);
            this.pictureBox139.TabIndex = 140;
            this.pictureBox139.TabStop = false;
            this.pictureBox139.Tag = "coinScore";
            // 
            // pictureBox140
            // 
            this.pictureBox140.BackColor = System.Drawing.Color.Orange;
            this.pictureBox140.Location = new System.Drawing.Point(300, 553);
            this.pictureBox140.Name = "pictureBox140";
            this.pictureBox140.Size = new System.Drawing.Size(10, 10);
            this.pictureBox140.TabIndex = 139;
            this.pictureBox140.TabStop = false;
            this.pictureBox140.Tag = "coinScore";
            // 
            // pictureBox141
            // 
            this.pictureBox141.BackColor = System.Drawing.Color.Orange;
            this.pictureBox141.Location = new System.Drawing.Point(325, 553);
            this.pictureBox141.Name = "pictureBox141";
            this.pictureBox141.Size = new System.Drawing.Size(10, 10);
            this.pictureBox141.TabIndex = 138;
            this.pictureBox141.TabStop = false;
            this.pictureBox141.Tag = "coinScore";
            // 
            // pictureBox142
            // 
            this.pictureBox142.BackColor = System.Drawing.Color.Orange;
            this.pictureBox142.Location = new System.Drawing.Point(350, 553);
            this.pictureBox142.Name = "pictureBox142";
            this.pictureBox142.Size = new System.Drawing.Size(10, 10);
            this.pictureBox142.TabIndex = 137;
            this.pictureBox142.TabStop = false;
            this.pictureBox142.Tag = "coinScore";
            // 
            // pictureBox143
            // 
            this.pictureBox143.BackColor = System.Drawing.Color.Orange;
            this.pictureBox143.Location = new System.Drawing.Point(375, 553);
            this.pictureBox143.Name = "pictureBox143";
            this.pictureBox143.Size = new System.Drawing.Size(10, 10);
            this.pictureBox143.TabIndex = 136;
            this.pictureBox143.TabStop = false;
            this.pictureBox143.Tag = "coinScore";
            // 
            // pictureBox144
            // 
            this.pictureBox144.BackColor = System.Drawing.Color.Orange;
            this.pictureBox144.Location = new System.Drawing.Point(397, 553);
            this.pictureBox144.Name = "pictureBox144";
            this.pictureBox144.Size = new System.Drawing.Size(10, 10);
            this.pictureBox144.TabIndex = 135;
            this.pictureBox144.TabStop = false;
            this.pictureBox144.Tag = "coinScore";
            // 
            // pictureBox145
            // 
            this.pictureBox145.BackColor = System.Drawing.Color.Orange;
            this.pictureBox145.Location = new System.Drawing.Point(420, 553);
            this.pictureBox145.Name = "pictureBox145";
            this.pictureBox145.Size = new System.Drawing.Size(10, 10);
            this.pictureBox145.TabIndex = 134;
            this.pictureBox145.TabStop = false;
            this.pictureBox145.Tag = "coinScore";
            // 
            // pictureBox146
            // 
            this.pictureBox146.BackColor = System.Drawing.Color.Orange;
            this.pictureBox146.Location = new System.Drawing.Point(445, 553);
            this.pictureBox146.Name = "pictureBox146";
            this.pictureBox146.Size = new System.Drawing.Size(10, 10);
            this.pictureBox146.TabIndex = 133;
            this.pictureBox146.TabStop = false;
            this.pictureBox146.Tag = "coinScore";
            // 
            // pictureBox147
            // 
            this.pictureBox147.BackColor = System.Drawing.Color.Orange;
            this.pictureBox147.Location = new System.Drawing.Point(470, 553);
            this.pictureBox147.Name = "pictureBox147";
            this.pictureBox147.Size = new System.Drawing.Size(10, 10);
            this.pictureBox147.TabIndex = 132;
            this.pictureBox147.TabStop = false;
            this.pictureBox147.Tag = "coinScore";
            // 
            // pictureBox148
            // 
            this.pictureBox148.BackColor = System.Drawing.Color.Orange;
            this.pictureBox148.Location = new System.Drawing.Point(495, 553);
            this.pictureBox148.Name = "pictureBox148";
            this.pictureBox148.Size = new System.Drawing.Size(10, 10);
            this.pictureBox148.TabIndex = 131;
            this.pictureBox148.TabStop = false;
            this.pictureBox148.Tag = "coinScore";
            // 
            // pictureBox149
            // 
            this.pictureBox149.BackColor = System.Drawing.Color.Orange;
            this.pictureBox149.Location = new System.Drawing.Point(517, 553);
            this.pictureBox149.Name = "pictureBox149";
            this.pictureBox149.Size = new System.Drawing.Size(10, 10);
            this.pictureBox149.TabIndex = 130;
            this.pictureBox149.TabStop = false;
            this.pictureBox149.Tag = "coinScore";
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Orange;
            this.pictureBox42.Location = new System.Drawing.Point(700, 553);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(10, 10);
            this.pictureBox42.TabIndex = 153;
            this.pictureBox42.TabStop = false;
            this.pictureBox42.Tag = "coinScore";
            // 
            // pictureBox150
            // 
            this.pictureBox150.BackColor = System.Drawing.Color.Orange;
            this.pictureBox150.Location = new System.Drawing.Point(725, 553);
            this.pictureBox150.Name = "pictureBox150";
            this.pictureBox150.Size = new System.Drawing.Size(10, 10);
            this.pictureBox150.TabIndex = 152;
            this.pictureBox150.TabStop = false;
            this.pictureBox150.Tag = "coinScore";
            // 
            // pictureBox151
            // 
            this.pictureBox151.BackColor = System.Drawing.Color.Orange;
            this.pictureBox151.Location = new System.Drawing.Point(750, 553);
            this.pictureBox151.Name = "pictureBox151";
            this.pictureBox151.Size = new System.Drawing.Size(10, 10);
            this.pictureBox151.TabIndex = 151;
            this.pictureBox151.TabStop = false;
            this.pictureBox151.Tag = "coinScore";
            // 
            // pictureBox152
            // 
            this.pictureBox152.BackColor = System.Drawing.Color.Orange;
            this.pictureBox152.Location = new System.Drawing.Point(772, 553);
            this.pictureBox152.Name = "pictureBox152";
            this.pictureBox152.Size = new System.Drawing.Size(10, 10);
            this.pictureBox152.TabIndex = 150;
            this.pictureBox152.TabStop = false;
            this.pictureBox152.Tag = "coinScore";
            // 
            // pictureBox153
            // 
            this.pictureBox153.BackColor = System.Drawing.Color.Orange;
            this.pictureBox153.Location = new System.Drawing.Point(547, 553);
            this.pictureBox153.Name = "pictureBox153";
            this.pictureBox153.Size = new System.Drawing.Size(10, 10);
            this.pictureBox153.TabIndex = 157;
            this.pictureBox153.TabStop = false;
            this.pictureBox153.Tag = "coinScore";
            // 
            // pictureBox154
            // 
            this.pictureBox154.BackColor = System.Drawing.Color.Orange;
            this.pictureBox154.Location = new System.Drawing.Point(572, 553);
            this.pictureBox154.Name = "pictureBox154";
            this.pictureBox154.Size = new System.Drawing.Size(10, 10);
            this.pictureBox154.TabIndex = 156;
            this.pictureBox154.TabStop = false;
            this.pictureBox154.Tag = "coinScore";
            // 
            // pictureBox155
            // 
            this.pictureBox155.BackColor = System.Drawing.Color.Orange;
            this.pictureBox155.Location = new System.Drawing.Point(597, 553);
            this.pictureBox155.Name = "pictureBox155";
            this.pictureBox155.Size = new System.Drawing.Size(10, 10);
            this.pictureBox155.TabIndex = 155;
            this.pictureBox155.TabStop = false;
            this.pictureBox155.Tag = "coinScore";
            // 
            // pictureBox156
            // 
            this.pictureBox156.BackColor = System.Drawing.Color.Orange;
            this.pictureBox156.Location = new System.Drawing.Point(619, 553);
            this.pictureBox156.Name = "pictureBox156";
            this.pictureBox156.Size = new System.Drawing.Size(10, 10);
            this.pictureBox156.TabIndex = 154;
            this.pictureBox156.TabStop = false;
            this.pictureBox156.Tag = "coinScore";
            // 
            // pictureBox157
            // 
            this.pictureBox157.BackColor = System.Drawing.Color.Orange;
            this.pictureBox157.Location = new System.Drawing.Point(58, 358);
            this.pictureBox157.Name = "pictureBox157";
            this.pictureBox157.Size = new System.Drawing.Size(10, 10);
            this.pictureBox157.TabIndex = 181;
            this.pictureBox157.TabStop = false;
            this.pictureBox157.Tag = "coinScore";
            // 
            // pictureBox158
            // 
            this.pictureBox158.BackColor = System.Drawing.Color.Orange;
            this.pictureBox158.Location = new System.Drawing.Point(83, 358);
            this.pictureBox158.Name = "pictureBox158";
            this.pictureBox158.Size = new System.Drawing.Size(10, 10);
            this.pictureBox158.TabIndex = 180;
            this.pictureBox158.TabStop = false;
            this.pictureBox158.Tag = "coinScore";
            // 
            // pictureBox159
            // 
            this.pictureBox159.BackColor = System.Drawing.Color.Orange;
            this.pictureBox159.Location = new System.Drawing.Point(108, 358);
            this.pictureBox159.Name = "pictureBox159";
            this.pictureBox159.Size = new System.Drawing.Size(10, 10);
            this.pictureBox159.TabIndex = 179;
            this.pictureBox159.TabStop = false;
            this.pictureBox159.Tag = "coinScore";
            // 
            // pictureBox160
            // 
            this.pictureBox160.BackColor = System.Drawing.Color.Orange;
            this.pictureBox160.Location = new System.Drawing.Point(130, 358);
            this.pictureBox160.Name = "pictureBox160";
            this.pictureBox160.Size = new System.Drawing.Size(10, 10);
            this.pictureBox160.TabIndex = 178;
            this.pictureBox160.TabStop = false;
            this.pictureBox160.Tag = "coinScore";
            // 
            // pictureBox161
            // 
            this.pictureBox161.BackColor = System.Drawing.Color.Orange;
            this.pictureBox161.Location = new System.Drawing.Point(155, 358);
            this.pictureBox161.Name = "pictureBox161";
            this.pictureBox161.Size = new System.Drawing.Size(10, 10);
            this.pictureBox161.TabIndex = 177;
            this.pictureBox161.TabStop = false;
            this.pictureBox161.Tag = "coinScore";
            // 
            // pictureBox162
            // 
            this.pictureBox162.BackColor = System.Drawing.Color.Orange;
            this.pictureBox162.Location = new System.Drawing.Point(180, 358);
            this.pictureBox162.Name = "pictureBox162";
            this.pictureBox162.Size = new System.Drawing.Size(10, 10);
            this.pictureBox162.TabIndex = 176;
            this.pictureBox162.TabStop = false;
            this.pictureBox162.Tag = "coinScore";
            // 
            // pictureBox163
            // 
            this.pictureBox163.BackColor = System.Drawing.Color.Orange;
            this.pictureBox163.Location = new System.Drawing.Point(205, 358);
            this.pictureBox163.Name = "pictureBox163";
            this.pictureBox163.Size = new System.Drawing.Size(10, 10);
            this.pictureBox163.TabIndex = 175;
            this.pictureBox163.TabStop = false;
            this.pictureBox163.Tag = "coinScore";
            // 
            // pictureBox164
            // 
            this.pictureBox164.BackColor = System.Drawing.Color.Orange;
            this.pictureBox164.Location = new System.Drawing.Point(230, 358);
            this.pictureBox164.Name = "pictureBox164";
            this.pictureBox164.Size = new System.Drawing.Size(10, 10);
            this.pictureBox164.TabIndex = 174;
            this.pictureBox164.TabStop = false;
            this.pictureBox164.Tag = "coinScore";
            // 
            // pictureBox165
            // 
            this.pictureBox165.BackColor = System.Drawing.Color.Orange;
            this.pictureBox165.Location = new System.Drawing.Point(252, 358);
            this.pictureBox165.Name = "pictureBox165";
            this.pictureBox165.Size = new System.Drawing.Size(10, 10);
            this.pictureBox165.TabIndex = 173;
            this.pictureBox165.TabStop = false;
            this.pictureBox165.Tag = "coinScore";
            // 
            // pictureBox166
            // 
            this.pictureBox166.BackColor = System.Drawing.Color.Orange;
            this.pictureBox166.Location = new System.Drawing.Point(275, 358);
            this.pictureBox166.Name = "pictureBox166";
            this.pictureBox166.Size = new System.Drawing.Size(10, 10);
            this.pictureBox166.TabIndex = 172;
            this.pictureBox166.TabStop = false;
            this.pictureBox166.Tag = "coinScore";
            // 
            // pictureBox167
            // 
            this.pictureBox167.BackColor = System.Drawing.Color.Orange;
            this.pictureBox167.Location = new System.Drawing.Point(300, 358);
            this.pictureBox167.Name = "pictureBox167";
            this.pictureBox167.Size = new System.Drawing.Size(10, 10);
            this.pictureBox167.TabIndex = 171;
            this.pictureBox167.TabStop = false;
            this.pictureBox167.Tag = "coinScore";
            // 
            // pictureBox168
            // 
            this.pictureBox168.BackColor = System.Drawing.Color.Orange;
            this.pictureBox168.Location = new System.Drawing.Point(325, 358);
            this.pictureBox168.Name = "pictureBox168";
            this.pictureBox168.Size = new System.Drawing.Size(10, 10);
            this.pictureBox168.TabIndex = 170;
            this.pictureBox168.TabStop = false;
            this.pictureBox168.Tag = "coinScore";
            // 
            // pictureBox169
            // 
            this.pictureBox169.BackColor = System.Drawing.Color.Orange;
            this.pictureBox169.Location = new System.Drawing.Point(350, 358);
            this.pictureBox169.Name = "pictureBox169";
            this.pictureBox169.Size = new System.Drawing.Size(10, 10);
            this.pictureBox169.TabIndex = 169;
            this.pictureBox169.TabStop = false;
            this.pictureBox169.Tag = "coinScore";
            // 
            // pictureBox170
            // 
            this.pictureBox170.BackColor = System.Drawing.Color.Orange;
            this.pictureBox170.Location = new System.Drawing.Point(372, 358);
            this.pictureBox170.Name = "pictureBox170";
            this.pictureBox170.Size = new System.Drawing.Size(10, 10);
            this.pictureBox170.TabIndex = 168;
            this.pictureBox170.TabStop = false;
            this.pictureBox170.Tag = "coinScore";
            // 
            // pictureBox171
            // 
            this.pictureBox171.BackColor = System.Drawing.Color.Orange;
            this.pictureBox171.Location = new System.Drawing.Point(392, 358);
            this.pictureBox171.Name = "pictureBox171";
            this.pictureBox171.Size = new System.Drawing.Size(10, 10);
            this.pictureBox171.TabIndex = 167;
            this.pictureBox171.TabStop = false;
            this.pictureBox171.Tag = "coinScore";
            // 
            // pictureBox172
            // 
            this.pictureBox172.BackColor = System.Drawing.Color.Orange;
            this.pictureBox172.Location = new System.Drawing.Point(417, 358);
            this.pictureBox172.Name = "pictureBox172";
            this.pictureBox172.Size = new System.Drawing.Size(10, 10);
            this.pictureBox172.TabIndex = 166;
            this.pictureBox172.TabStop = false;
            this.pictureBox172.Tag = "coinScore";
            // 
            // pictureBox173
            // 
            this.pictureBox173.BackColor = System.Drawing.Color.Orange;
            this.pictureBox173.Location = new System.Drawing.Point(442, 358);
            this.pictureBox173.Name = "pictureBox173";
            this.pictureBox173.Size = new System.Drawing.Size(10, 10);
            this.pictureBox173.TabIndex = 165;
            this.pictureBox173.TabStop = false;
            this.pictureBox173.Tag = "coinScore";
            // 
            // pictureBox174
            // 
            this.pictureBox174.BackColor = System.Drawing.Color.Orange;
            this.pictureBox174.Location = new System.Drawing.Point(467, 358);
            this.pictureBox174.Name = "pictureBox174";
            this.pictureBox174.Size = new System.Drawing.Size(10, 10);
            this.pictureBox174.TabIndex = 164;
            this.pictureBox174.TabStop = false;
            this.pictureBox174.Tag = "coinScore";
            // 
            // pictureBox175
            // 
            this.pictureBox175.BackColor = System.Drawing.Color.Orange;
            this.pictureBox175.Location = new System.Drawing.Point(489, 358);
            this.pictureBox175.Name = "pictureBox175";
            this.pictureBox175.Size = new System.Drawing.Size(10, 10);
            this.pictureBox175.TabIndex = 163;
            this.pictureBox175.TabStop = false;
            this.pictureBox175.Tag = "coinScore";
            // 
            // pictureBox176
            // 
            this.pictureBox176.BackColor = System.Drawing.Color.Orange;
            this.pictureBox176.Location = new System.Drawing.Point(512, 358);
            this.pictureBox176.Name = "pictureBox176";
            this.pictureBox176.Size = new System.Drawing.Size(10, 10);
            this.pictureBox176.TabIndex = 162;
            this.pictureBox176.TabStop = false;
            this.pictureBox176.Tag = "coinScore";
            // 
            // pictureBox177
            // 
            this.pictureBox177.BackColor = System.Drawing.Color.Orange;
            this.pictureBox177.Location = new System.Drawing.Point(537, 358);
            this.pictureBox177.Name = "pictureBox177";
            this.pictureBox177.Size = new System.Drawing.Size(10, 10);
            this.pictureBox177.TabIndex = 161;
            this.pictureBox177.TabStop = false;
            this.pictureBox177.Tag = "coinScore";
            // 
            // pictureBox178
            // 
            this.pictureBox178.BackColor = System.Drawing.Color.Orange;
            this.pictureBox178.Location = new System.Drawing.Point(562, 358);
            this.pictureBox178.Name = "pictureBox178";
            this.pictureBox178.Size = new System.Drawing.Size(10, 10);
            this.pictureBox178.TabIndex = 160;
            this.pictureBox178.TabStop = false;
            this.pictureBox178.Tag = "coinScore";
            // 
            // pictureBox179
            // 
            this.pictureBox179.BackColor = System.Drawing.Color.Orange;
            this.pictureBox179.Location = new System.Drawing.Point(587, 358);
            this.pictureBox179.Name = "pictureBox179";
            this.pictureBox179.Size = new System.Drawing.Size(10, 10);
            this.pictureBox179.TabIndex = 159;
            this.pictureBox179.TabStop = false;
            this.pictureBox179.Tag = "coinScore";
            // 
            // pictureBox180
            // 
            this.pictureBox180.BackColor = System.Drawing.Color.Orange;
            this.pictureBox180.Location = new System.Drawing.Point(609, 358);
            this.pictureBox180.Name = "pictureBox180";
            this.pictureBox180.Size = new System.Drawing.Size(10, 10);
            this.pictureBox180.TabIndex = 158;
            this.pictureBox180.TabStop = false;
            this.pictureBox180.Tag = "coinScore";
            // 
            // pictureBox181
            // 
            this.pictureBox181.BackColor = System.Drawing.Color.Orange;
            this.pictureBox181.Location = new System.Drawing.Point(72, 42);
            this.pictureBox181.Name = "pictureBox181";
            this.pictureBox181.Size = new System.Drawing.Size(10, 10);
            this.pictureBox181.TabIndex = 205;
            this.pictureBox181.TabStop = false;
            this.pictureBox181.Tag = "coinScore";
            // 
            // pictureBox182
            // 
            this.pictureBox182.BackColor = System.Drawing.Color.Orange;
            this.pictureBox182.Location = new System.Drawing.Point(95, 42);
            this.pictureBox182.Name = "pictureBox182";
            this.pictureBox182.Size = new System.Drawing.Size(10, 10);
            this.pictureBox182.TabIndex = 204;
            this.pictureBox182.TabStop = false;
            this.pictureBox182.Tag = "coinScore";
            // 
            // pictureBox183
            // 
            this.pictureBox183.BackColor = System.Drawing.Color.Orange;
            this.pictureBox183.Location = new System.Drawing.Point(120, 42);
            this.pictureBox183.Name = "pictureBox183";
            this.pictureBox183.Size = new System.Drawing.Size(10, 10);
            this.pictureBox183.TabIndex = 203;
            this.pictureBox183.TabStop = false;
            this.pictureBox183.Tag = "coinScore";
            // 
            // pictureBox184
            // 
            this.pictureBox184.BackColor = System.Drawing.Color.Orange;
            this.pictureBox184.Location = new System.Drawing.Point(142, 42);
            this.pictureBox184.Name = "pictureBox184";
            this.pictureBox184.Size = new System.Drawing.Size(10, 10);
            this.pictureBox184.TabIndex = 202;
            this.pictureBox184.TabStop = false;
            this.pictureBox184.Tag = "coinScore";
            // 
            // pictureBox185
            // 
            this.pictureBox185.BackColor = System.Drawing.Color.Orange;
            this.pictureBox185.Location = new System.Drawing.Point(167, 42);
            this.pictureBox185.Name = "pictureBox185";
            this.pictureBox185.Size = new System.Drawing.Size(10, 10);
            this.pictureBox185.TabIndex = 201;
            this.pictureBox185.TabStop = false;
            this.pictureBox185.Tag = "coinScore";
            // 
            // pictureBox186
            // 
            this.pictureBox186.BackColor = System.Drawing.Color.Orange;
            this.pictureBox186.Location = new System.Drawing.Point(192, 42);
            this.pictureBox186.Name = "pictureBox186";
            this.pictureBox186.Size = new System.Drawing.Size(10, 10);
            this.pictureBox186.TabIndex = 200;
            this.pictureBox186.TabStop = false;
            this.pictureBox186.Tag = "coinScore";
            // 
            // pictureBox187
            // 
            this.pictureBox187.BackColor = System.Drawing.Color.Orange;
            this.pictureBox187.Location = new System.Drawing.Point(217, 42);
            this.pictureBox187.Name = "pictureBox187";
            this.pictureBox187.Size = new System.Drawing.Size(10, 10);
            this.pictureBox187.TabIndex = 199;
            this.pictureBox187.TabStop = false;
            this.pictureBox187.Tag = "coinScore";
            // 
            // pictureBox188
            // 
            this.pictureBox188.BackColor = System.Drawing.Color.Orange;
            this.pictureBox188.Location = new System.Drawing.Point(242, 42);
            this.pictureBox188.Name = "pictureBox188";
            this.pictureBox188.Size = new System.Drawing.Size(10, 10);
            this.pictureBox188.TabIndex = 198;
            this.pictureBox188.TabStop = false;
            this.pictureBox188.Tag = "coinScore";
            // 
            // pictureBox189
            // 
            this.pictureBox189.BackColor = System.Drawing.Color.Orange;
            this.pictureBox189.Location = new System.Drawing.Point(264, 42);
            this.pictureBox189.Name = "pictureBox189";
            this.pictureBox189.Size = new System.Drawing.Size(10, 10);
            this.pictureBox189.TabIndex = 197;
            this.pictureBox189.TabStop = false;
            this.pictureBox189.Tag = "coinScore";
            // 
            // pictureBox190
            // 
            this.pictureBox190.BackColor = System.Drawing.Color.Orange;
            this.pictureBox190.Location = new System.Drawing.Point(287, 42);
            this.pictureBox190.Name = "pictureBox190";
            this.pictureBox190.Size = new System.Drawing.Size(10, 10);
            this.pictureBox190.TabIndex = 196;
            this.pictureBox190.TabStop = false;
            this.pictureBox190.Tag = "coinScore";
            // 
            // pictureBox191
            // 
            this.pictureBox191.BackColor = System.Drawing.Color.Orange;
            this.pictureBox191.Location = new System.Drawing.Point(312, 42);
            this.pictureBox191.Name = "pictureBox191";
            this.pictureBox191.Size = new System.Drawing.Size(10, 10);
            this.pictureBox191.TabIndex = 195;
            this.pictureBox191.TabStop = false;
            this.pictureBox191.Tag = "coinScore";
            // 
            // pictureBox192
            // 
            this.pictureBox192.BackColor = System.Drawing.Color.Orange;
            this.pictureBox192.Location = new System.Drawing.Point(337, 42);
            this.pictureBox192.Name = "pictureBox192";
            this.pictureBox192.Size = new System.Drawing.Size(10, 10);
            this.pictureBox192.TabIndex = 194;
            this.pictureBox192.TabStop = false;
            this.pictureBox192.Tag = "coinScore";
            // 
            // pictureBox193
            // 
            this.pictureBox193.BackColor = System.Drawing.Color.Orange;
            this.pictureBox193.Location = new System.Drawing.Point(362, 42);
            this.pictureBox193.Name = "pictureBox193";
            this.pictureBox193.Size = new System.Drawing.Size(10, 10);
            this.pictureBox193.TabIndex = 193;
            this.pictureBox193.TabStop = false;
            this.pictureBox193.Tag = "coinScore";
            // 
            // pictureBox194
            // 
            this.pictureBox194.BackColor = System.Drawing.Color.Orange;
            this.pictureBox194.Location = new System.Drawing.Point(384, 42);
            this.pictureBox194.Name = "pictureBox194";
            this.pictureBox194.Size = new System.Drawing.Size(10, 10);
            this.pictureBox194.TabIndex = 192;
            this.pictureBox194.TabStop = false;
            this.pictureBox194.Tag = "coinScore";
            // 
            // pictureBox195
            // 
            this.pictureBox195.BackColor = System.Drawing.Color.Orange;
            this.pictureBox195.Location = new System.Drawing.Point(404, 42);
            this.pictureBox195.Name = "pictureBox195";
            this.pictureBox195.Size = new System.Drawing.Size(10, 10);
            this.pictureBox195.TabIndex = 191;
            this.pictureBox195.TabStop = false;
            this.pictureBox195.Tag = "coinScore";
            // 
            // pictureBox196
            // 
            this.pictureBox196.BackColor = System.Drawing.Color.Orange;
            this.pictureBox196.Location = new System.Drawing.Point(429, 42);
            this.pictureBox196.Name = "pictureBox196";
            this.pictureBox196.Size = new System.Drawing.Size(10, 10);
            this.pictureBox196.TabIndex = 190;
            this.pictureBox196.TabStop = false;
            this.pictureBox196.Tag = "coinScore";
            // 
            // pictureBox197
            // 
            this.pictureBox197.BackColor = System.Drawing.Color.Orange;
            this.pictureBox197.Location = new System.Drawing.Point(454, 42);
            this.pictureBox197.Name = "pictureBox197";
            this.pictureBox197.Size = new System.Drawing.Size(10, 10);
            this.pictureBox197.TabIndex = 189;
            this.pictureBox197.TabStop = false;
            this.pictureBox197.Tag = "coinScore";
            // 
            // pictureBox198
            // 
            this.pictureBox198.BackColor = System.Drawing.Color.Orange;
            this.pictureBox198.Location = new System.Drawing.Point(479, 42);
            this.pictureBox198.Name = "pictureBox198";
            this.pictureBox198.Size = new System.Drawing.Size(10, 10);
            this.pictureBox198.TabIndex = 188;
            this.pictureBox198.TabStop = false;
            this.pictureBox198.Tag = "coinScore";
            // 
            // pictureBox199
            // 
            this.pictureBox199.BackColor = System.Drawing.Color.Orange;
            this.pictureBox199.Location = new System.Drawing.Point(501, 42);
            this.pictureBox199.Name = "pictureBox199";
            this.pictureBox199.Size = new System.Drawing.Size(10, 10);
            this.pictureBox199.TabIndex = 187;
            this.pictureBox199.TabStop = false;
            this.pictureBox199.Tag = "coinScore";
            // 
            // pictureBox200
            // 
            this.pictureBox200.BackColor = System.Drawing.Color.Orange;
            this.pictureBox200.Location = new System.Drawing.Point(524, 42);
            this.pictureBox200.Name = "pictureBox200";
            this.pictureBox200.Size = new System.Drawing.Size(10, 10);
            this.pictureBox200.TabIndex = 186;
            this.pictureBox200.TabStop = false;
            this.pictureBox200.Tag = "coinScore";
            // 
            // pictureBox201
            // 
            this.pictureBox201.BackColor = System.Drawing.Color.Orange;
            this.pictureBox201.Location = new System.Drawing.Point(549, 42);
            this.pictureBox201.Name = "pictureBox201";
            this.pictureBox201.Size = new System.Drawing.Size(10, 10);
            this.pictureBox201.TabIndex = 185;
            this.pictureBox201.TabStop = false;
            this.pictureBox201.Tag = "coinScore";
            // 
            // pictureBox202
            // 
            this.pictureBox202.BackColor = System.Drawing.Color.Orange;
            this.pictureBox202.Location = new System.Drawing.Point(574, 42);
            this.pictureBox202.Name = "pictureBox202";
            this.pictureBox202.Size = new System.Drawing.Size(10, 10);
            this.pictureBox202.TabIndex = 184;
            this.pictureBox202.TabStop = false;
            this.pictureBox202.Tag = "coinScore";
            // 
            // pictureBox203
            // 
            this.pictureBox203.BackColor = System.Drawing.Color.Orange;
            this.pictureBox203.Location = new System.Drawing.Point(599, 42);
            this.pictureBox203.Name = "pictureBox203";
            this.pictureBox203.Size = new System.Drawing.Size(10, 10);
            this.pictureBox203.TabIndex = 183;
            this.pictureBox203.TabStop = false;
            this.pictureBox203.Tag = "coinScore";
            // 
            // pictureBox204
            // 
            this.pictureBox204.BackColor = System.Drawing.Color.Orange;
            this.pictureBox204.Location = new System.Drawing.Point(621, 42);
            this.pictureBox204.Name = "pictureBox204";
            this.pictureBox204.Size = new System.Drawing.Size(10, 10);
            this.pictureBox204.TabIndex = 182;
            this.pictureBox204.TabStop = false;
            this.pictureBox204.Tag = "coinScore";
            // 
            // pictureBox205
            // 
            this.pictureBox205.BackColor = System.Drawing.Color.Orange;
            this.pictureBox205.Location = new System.Drawing.Point(651, 42);
            this.pictureBox205.Name = "pictureBox205";
            this.pictureBox205.Size = new System.Drawing.Size(10, 10);
            this.pictureBox205.TabIndex = 229;
            this.pictureBox205.TabStop = false;
            this.pictureBox205.Tag = "coinScore";
            // 
            // pictureBox206
            // 
            this.pictureBox206.BackColor = System.Drawing.Color.Orange;
            this.pictureBox206.Location = new System.Drawing.Point(676, 42);
            this.pictureBox206.Name = "pictureBox206";
            this.pictureBox206.Size = new System.Drawing.Size(10, 10);
            this.pictureBox206.TabIndex = 228;
            this.pictureBox206.TabStop = false;
            this.pictureBox206.Tag = "coinScore";
            // 
            // pictureBox207
            // 
            this.pictureBox207.BackColor = System.Drawing.Color.Orange;
            this.pictureBox207.Location = new System.Drawing.Point(701, 42);
            this.pictureBox207.Name = "pictureBox207";
            this.pictureBox207.Size = new System.Drawing.Size(10, 10);
            this.pictureBox207.TabIndex = 227;
            this.pictureBox207.TabStop = false;
            this.pictureBox207.Tag = "coinScore";
            // 
            // pictureBox208
            // 
            this.pictureBox208.BackColor = System.Drawing.Color.Orange;
            this.pictureBox208.Location = new System.Drawing.Point(723, 42);
            this.pictureBox208.Name = "pictureBox208";
            this.pictureBox208.Size = new System.Drawing.Size(10, 10);
            this.pictureBox208.TabIndex = 226;
            this.pictureBox208.TabStop = false;
            this.pictureBox208.Tag = "coinScore";
            // 
            // pictureBox209
            // 
            this.pictureBox209.BackColor = System.Drawing.Color.Orange;
            this.pictureBox209.Location = new System.Drawing.Point(748, 42);
            this.pictureBox209.Name = "pictureBox209";
            this.pictureBox209.Size = new System.Drawing.Size(10, 10);
            this.pictureBox209.TabIndex = 225;
            this.pictureBox209.TabStop = false;
            this.pictureBox209.Tag = "coinScore";
            // 
            // pictureBox210
            // 
            this.pictureBox210.BackColor = System.Drawing.Color.Orange;
            this.pictureBox210.Location = new System.Drawing.Point(773, 42);
            this.pictureBox210.Name = "pictureBox210";
            this.pictureBox210.Size = new System.Drawing.Size(10, 10);
            this.pictureBox210.TabIndex = 224;
            this.pictureBox210.TabStop = false;
            this.pictureBox210.Tag = "coinScore";
            // 
            // pictureBox211
            // 
            this.pictureBox211.BackColor = System.Drawing.Color.Orange;
            this.pictureBox211.Location = new System.Drawing.Point(798, 42);
            this.pictureBox211.Name = "pictureBox211";
            this.pictureBox211.Size = new System.Drawing.Size(10, 10);
            this.pictureBox211.TabIndex = 223;
            this.pictureBox211.TabStop = false;
            this.pictureBox211.Tag = "coinScore";
            // 
            // pictureBox212
            // 
            this.pictureBox212.BackColor = System.Drawing.Color.Orange;
            this.pictureBox212.Location = new System.Drawing.Point(823, 42);
            this.pictureBox212.Name = "pictureBox212";
            this.pictureBox212.Size = new System.Drawing.Size(10, 10);
            this.pictureBox212.TabIndex = 222;
            this.pictureBox212.TabStop = false;
            this.pictureBox212.Tag = "coinScore";
            // 
            // pictureBox213
            // 
            this.pictureBox213.BackColor = System.Drawing.Color.Orange;
            this.pictureBox213.Location = new System.Drawing.Point(845, 42);
            this.pictureBox213.Name = "pictureBox213";
            this.pictureBox213.Size = new System.Drawing.Size(10, 10);
            this.pictureBox213.TabIndex = 221;
            this.pictureBox213.TabStop = false;
            this.pictureBox213.Tag = "coinScore";
            // 
            // pictureBox214
            // 
            this.pictureBox214.BackColor = System.Drawing.Color.Orange;
            this.pictureBox214.Location = new System.Drawing.Point(868, 42);
            this.pictureBox214.Name = "pictureBox214";
            this.pictureBox214.Size = new System.Drawing.Size(10, 10);
            this.pictureBox214.TabIndex = 220;
            this.pictureBox214.TabStop = false;
            this.pictureBox214.Tag = "coinScore";
            // 
            // pictureBox215
            // 
            this.pictureBox215.BackColor = System.Drawing.Color.Orange;
            this.pictureBox215.Location = new System.Drawing.Point(893, 42);
            this.pictureBox215.Name = "pictureBox215";
            this.pictureBox215.Size = new System.Drawing.Size(10, 10);
            this.pictureBox215.TabIndex = 219;
            this.pictureBox215.TabStop = false;
            this.pictureBox215.Tag = "coinScore";
            // 
            // pictureBox216
            // 
            this.pictureBox216.BackColor = System.Drawing.Color.Orange;
            this.pictureBox216.Location = new System.Drawing.Point(918, 42);
            this.pictureBox216.Name = "pictureBox216";
            this.pictureBox216.Size = new System.Drawing.Size(10, 10);
            this.pictureBox216.TabIndex = 218;
            this.pictureBox216.TabStop = false;
            this.pictureBox216.Tag = "coinScore";
            // 
            // pictureBox217
            // 
            this.pictureBox217.BackColor = System.Drawing.Color.Orange;
            this.pictureBox217.Location = new System.Drawing.Point(943, 42);
            this.pictureBox217.Name = "pictureBox217";
            this.pictureBox217.Size = new System.Drawing.Size(10, 10);
            this.pictureBox217.TabIndex = 217;
            this.pictureBox217.TabStop = false;
            this.pictureBox217.Tag = "coinScore";
            // 
            // pictureBox218
            // 
            this.pictureBox218.BackColor = System.Drawing.Color.Orange;
            this.pictureBox218.Location = new System.Drawing.Point(965, 42);
            this.pictureBox218.Name = "pictureBox218";
            this.pictureBox218.Size = new System.Drawing.Size(10, 10);
            this.pictureBox218.TabIndex = 216;
            this.pictureBox218.TabStop = false;
            this.pictureBox218.Tag = "coinScore";
            // 
            // pictureBox219
            // 
            this.pictureBox219.BackColor = System.Drawing.Color.Orange;
            this.pictureBox219.Location = new System.Drawing.Point(985, 42);
            this.pictureBox219.Name = "pictureBox219";
            this.pictureBox219.Size = new System.Drawing.Size(10, 10);
            this.pictureBox219.TabIndex = 215;
            this.pictureBox219.TabStop = false;
            this.pictureBox219.Tag = "coinScore";
            // 
            // pictureBox220
            // 
            this.pictureBox220.BackColor = System.Drawing.Color.Orange;
            this.pictureBox220.Location = new System.Drawing.Point(1010, 42);
            this.pictureBox220.Name = "pictureBox220";
            this.pictureBox220.Size = new System.Drawing.Size(10, 10);
            this.pictureBox220.TabIndex = 214;
            this.pictureBox220.TabStop = false;
            this.pictureBox220.Tag = "coinScore";
            // 
            // pictureBox221
            // 
            this.pictureBox221.BackColor = System.Drawing.Color.Orange;
            this.pictureBox221.Location = new System.Drawing.Point(1035, 42);
            this.pictureBox221.Name = "pictureBox221";
            this.pictureBox221.Size = new System.Drawing.Size(10, 10);
            this.pictureBox221.TabIndex = 213;
            this.pictureBox221.TabStop = false;
            this.pictureBox221.Tag = "coinScore";
            // 
            // pictureBox222
            // 
            this.pictureBox222.BackColor = System.Drawing.Color.Orange;
            this.pictureBox222.Location = new System.Drawing.Point(1060, 42);
            this.pictureBox222.Name = "pictureBox222";
            this.pictureBox222.Size = new System.Drawing.Size(10, 10);
            this.pictureBox222.TabIndex = 212;
            this.pictureBox222.TabStop = false;
            this.pictureBox222.Tag = "coinScore";
            // 
            // pictureBox223
            // 
            this.pictureBox223.BackColor = System.Drawing.Color.Orange;
            this.pictureBox223.Location = new System.Drawing.Point(1082, 42);
            this.pictureBox223.Name = "pictureBox223";
            this.pictureBox223.Size = new System.Drawing.Size(10, 10);
            this.pictureBox223.TabIndex = 211;
            this.pictureBox223.TabStop = false;
            this.pictureBox223.Tag = "coinScore";
            // 
            // pictureBox224
            // 
            this.pictureBox224.BackColor = System.Drawing.Color.Orange;
            this.pictureBox224.Location = new System.Drawing.Point(1105, 42);
            this.pictureBox224.Name = "pictureBox224";
            this.pictureBox224.Size = new System.Drawing.Size(10, 10);
            this.pictureBox224.TabIndex = 210;
            this.pictureBox224.TabStop = false;
            this.pictureBox224.Tag = "coinScore";
            // 
            // pictureBox225
            // 
            this.pictureBox225.BackColor = System.Drawing.Color.Orange;
            this.pictureBox225.Location = new System.Drawing.Point(1130, 42);
            this.pictureBox225.Name = "pictureBox225";
            this.pictureBox225.Size = new System.Drawing.Size(10, 10);
            this.pictureBox225.TabIndex = 209;
            this.pictureBox225.TabStop = false;
            this.pictureBox225.Tag = "coinScore";
            // 
            // pictureBox226
            // 
            this.pictureBox226.BackColor = System.Drawing.Color.Orange;
            this.pictureBox226.Location = new System.Drawing.Point(1155, 42);
            this.pictureBox226.Name = "pictureBox226";
            this.pictureBox226.Size = new System.Drawing.Size(10, 10);
            this.pictureBox226.TabIndex = 208;
            this.pictureBox226.TabStop = false;
            this.pictureBox226.Tag = "coinScore";
            // 
            // pictureBox227
            // 
            this.pictureBox227.BackColor = System.Drawing.Color.Orange;
            this.pictureBox227.Location = new System.Drawing.Point(1180, 42);
            this.pictureBox227.Name = "pictureBox227";
            this.pictureBox227.Size = new System.Drawing.Size(10, 10);
            this.pictureBox227.TabIndex = 207;
            this.pictureBox227.TabStop = false;
            this.pictureBox227.Tag = "coinScore";
            // 
            // pictureBox228
            // 
            this.pictureBox228.BackColor = System.Drawing.Color.Orange;
            this.pictureBox228.Location = new System.Drawing.Point(1202, 42);
            this.pictureBox228.Name = "pictureBox228";
            this.pictureBox228.Size = new System.Drawing.Size(10, 10);
            this.pictureBox228.TabIndex = 206;
            this.pictureBox228.TabStop = false;
            this.pictureBox228.Tag = "coinScore";
            // 
            // pictureBox229
            // 
            this.pictureBox229.BackColor = System.Drawing.Color.Orange;
            this.pictureBox229.Location = new System.Drawing.Point(858, 358);
            this.pictureBox229.Name = "pictureBox229";
            this.pictureBox229.Size = new System.Drawing.Size(10, 10);
            this.pictureBox229.TabIndex = 247;
            this.pictureBox229.TabStop = false;
            this.pictureBox229.Tag = "coinScore";
            // 
            // pictureBox230
            // 
            this.pictureBox230.BackColor = System.Drawing.Color.Orange;
            this.pictureBox230.Location = new System.Drawing.Point(881, 358);
            this.pictureBox230.Name = "pictureBox230";
            this.pictureBox230.Size = new System.Drawing.Size(10, 10);
            this.pictureBox230.TabIndex = 246;
            this.pictureBox230.TabStop = false;
            this.pictureBox230.Tag = "coinScore";
            // 
            // pictureBox231
            // 
            this.pictureBox231.BackColor = System.Drawing.Color.Orange;
            this.pictureBox231.Location = new System.Drawing.Point(906, 358);
            this.pictureBox231.Name = "pictureBox231";
            this.pictureBox231.Size = new System.Drawing.Size(10, 10);
            this.pictureBox231.TabIndex = 245;
            this.pictureBox231.TabStop = false;
            this.pictureBox231.Tag = "coinScore";
            // 
            // pictureBox232
            // 
            this.pictureBox232.BackColor = System.Drawing.Color.Orange;
            this.pictureBox232.Location = new System.Drawing.Point(931, 358);
            this.pictureBox232.Name = "pictureBox232";
            this.pictureBox232.Size = new System.Drawing.Size(10, 10);
            this.pictureBox232.TabIndex = 244;
            this.pictureBox232.TabStop = false;
            this.pictureBox232.Tag = "coinScore";
            // 
            // pictureBox233
            // 
            this.pictureBox233.BackColor = System.Drawing.Color.Orange;
            this.pictureBox233.Location = new System.Drawing.Point(956, 358);
            this.pictureBox233.Name = "pictureBox233";
            this.pictureBox233.Size = new System.Drawing.Size(10, 10);
            this.pictureBox233.TabIndex = 243;
            this.pictureBox233.TabStop = false;
            this.pictureBox233.Tag = "coinScore";
            // 
            // pictureBox234
            // 
            this.pictureBox234.BackColor = System.Drawing.Color.Orange;
            this.pictureBox234.Location = new System.Drawing.Point(978, 358);
            this.pictureBox234.Name = "pictureBox234";
            this.pictureBox234.Size = new System.Drawing.Size(10, 10);
            this.pictureBox234.TabIndex = 242;
            this.pictureBox234.TabStop = false;
            this.pictureBox234.Tag = "coinScore";
            // 
            // pictureBox235
            // 
            this.pictureBox235.BackColor = System.Drawing.Color.Orange;
            this.pictureBox235.Location = new System.Drawing.Point(998, 358);
            this.pictureBox235.Name = "pictureBox235";
            this.pictureBox235.Size = new System.Drawing.Size(10, 10);
            this.pictureBox235.TabIndex = 241;
            this.pictureBox235.TabStop = false;
            this.pictureBox235.Tag = "coinScore";
            // 
            // pictureBox236
            // 
            this.pictureBox236.BackColor = System.Drawing.Color.Orange;
            this.pictureBox236.Location = new System.Drawing.Point(1023, 358);
            this.pictureBox236.Name = "pictureBox236";
            this.pictureBox236.Size = new System.Drawing.Size(10, 10);
            this.pictureBox236.TabIndex = 240;
            this.pictureBox236.TabStop = false;
            this.pictureBox236.Tag = "coinScore";
            // 
            // pictureBox237
            // 
            this.pictureBox237.BackColor = System.Drawing.Color.Orange;
            this.pictureBox237.Location = new System.Drawing.Point(1048, 358);
            this.pictureBox237.Name = "pictureBox237";
            this.pictureBox237.Size = new System.Drawing.Size(10, 10);
            this.pictureBox237.TabIndex = 239;
            this.pictureBox237.TabStop = false;
            this.pictureBox237.Tag = "coinScore";
            // 
            // pictureBox238
            // 
            this.pictureBox238.BackColor = System.Drawing.Color.Orange;
            this.pictureBox238.Location = new System.Drawing.Point(1073, 358);
            this.pictureBox238.Name = "pictureBox238";
            this.pictureBox238.Size = new System.Drawing.Size(10, 10);
            this.pictureBox238.TabIndex = 238;
            this.pictureBox238.TabStop = false;
            this.pictureBox238.Tag = "coinScore";
            // 
            // pictureBox239
            // 
            this.pictureBox239.BackColor = System.Drawing.Color.Orange;
            this.pictureBox239.Location = new System.Drawing.Point(1095, 358);
            this.pictureBox239.Name = "pictureBox239";
            this.pictureBox239.Size = new System.Drawing.Size(10, 10);
            this.pictureBox239.TabIndex = 237;
            this.pictureBox239.TabStop = false;
            this.pictureBox239.Tag = "coinScore";
            // 
            // pictureBox240
            // 
            this.pictureBox240.BackColor = System.Drawing.Color.Orange;
            this.pictureBox240.Location = new System.Drawing.Point(1118, 358);
            this.pictureBox240.Name = "pictureBox240";
            this.pictureBox240.Size = new System.Drawing.Size(10, 10);
            this.pictureBox240.TabIndex = 236;
            this.pictureBox240.TabStop = false;
            this.pictureBox240.Tag = "coinScore";
            // 
            // pictureBox241
            // 
            this.pictureBox241.BackColor = System.Drawing.Color.Orange;
            this.pictureBox241.Location = new System.Drawing.Point(1143, 358);
            this.pictureBox241.Name = "pictureBox241";
            this.pictureBox241.Size = new System.Drawing.Size(10, 10);
            this.pictureBox241.TabIndex = 235;
            this.pictureBox241.TabStop = false;
            this.pictureBox241.Tag = "coinScore";
            // 
            // pictureBox242
            // 
            this.pictureBox242.BackColor = System.Drawing.Color.Orange;
            this.pictureBox242.Location = new System.Drawing.Point(1168, 358);
            this.pictureBox242.Name = "pictureBox242";
            this.pictureBox242.Size = new System.Drawing.Size(10, 10);
            this.pictureBox242.TabIndex = 234;
            this.pictureBox242.TabStop = false;
            this.pictureBox242.Tag = "coinScore";
            // 
            // pictureBox243
            // 
            this.pictureBox243.BackColor = System.Drawing.Color.Orange;
            this.pictureBox243.Location = new System.Drawing.Point(1193, 358);
            this.pictureBox243.Name = "pictureBox243";
            this.pictureBox243.Size = new System.Drawing.Size(10, 10);
            this.pictureBox243.TabIndex = 233;
            this.pictureBox243.TabStop = false;
            this.pictureBox243.Tag = "coinScore";
            // 
            // pictureBox244
            // 
            this.pictureBox244.BackColor = System.Drawing.Color.Orange;
            this.pictureBox244.Location = new System.Drawing.Point(1215, 358);
            this.pictureBox244.Name = "pictureBox244";
            this.pictureBox244.Size = new System.Drawing.Size(10, 10);
            this.pictureBox244.TabIndex = 232;
            this.pictureBox244.TabStop = false;
            this.pictureBox244.Tag = "coinScore";
            // 
            // pictureBox245
            // 
            this.pictureBox245.BackColor = System.Drawing.Color.Orange;
            this.pictureBox245.Location = new System.Drawing.Point(1240, 358);
            this.pictureBox245.Name = "pictureBox245";
            this.pictureBox245.Size = new System.Drawing.Size(10, 10);
            this.pictureBox245.TabIndex = 231;
            this.pictureBox245.TabStop = false;
            this.pictureBox245.Tag = "coinScore";
            // 
            // pictureBox246
            // 
            this.pictureBox246.BackColor = System.Drawing.Color.Orange;
            this.pictureBox246.Location = new System.Drawing.Point(1262, 358);
            this.pictureBox246.Name = "pictureBox246";
            this.pictureBox246.Size = new System.Drawing.Size(10, 10);
            this.pictureBox246.TabIndex = 230;
            this.pictureBox246.TabStop = false;
            this.pictureBox246.Tag = "coinScore";
            // 
            // pictureBox247
            // 
            this.pictureBox247.BackColor = System.Drawing.Color.Orange;
            this.pictureBox247.Location = new System.Drawing.Point(858, 307);
            this.pictureBox247.Name = "pictureBox247";
            this.pictureBox247.Size = new System.Drawing.Size(10, 10);
            this.pictureBox247.TabIndex = 265;
            this.pictureBox247.TabStop = false;
            this.pictureBox247.Tag = "coinScore";
            // 
            // pictureBox248
            // 
            this.pictureBox248.BackColor = System.Drawing.Color.Orange;
            this.pictureBox248.Location = new System.Drawing.Point(881, 307);
            this.pictureBox248.Name = "pictureBox248";
            this.pictureBox248.Size = new System.Drawing.Size(10, 10);
            this.pictureBox248.TabIndex = 264;
            this.pictureBox248.TabStop = false;
            this.pictureBox248.Tag = "coinScore";
            // 
            // pictureBox249
            // 
            this.pictureBox249.BackColor = System.Drawing.Color.Orange;
            this.pictureBox249.Location = new System.Drawing.Point(906, 307);
            this.pictureBox249.Name = "pictureBox249";
            this.pictureBox249.Size = new System.Drawing.Size(10, 10);
            this.pictureBox249.TabIndex = 263;
            this.pictureBox249.TabStop = false;
            this.pictureBox249.Tag = "coinScore";
            // 
            // pictureBox250
            // 
            this.pictureBox250.BackColor = System.Drawing.Color.Orange;
            this.pictureBox250.Location = new System.Drawing.Point(931, 307);
            this.pictureBox250.Name = "pictureBox250";
            this.pictureBox250.Size = new System.Drawing.Size(10, 10);
            this.pictureBox250.TabIndex = 262;
            this.pictureBox250.TabStop = false;
            this.pictureBox250.Tag = "coinScore";
            // 
            // pictureBox251
            // 
            this.pictureBox251.BackColor = System.Drawing.Color.Orange;
            this.pictureBox251.Location = new System.Drawing.Point(956, 307);
            this.pictureBox251.Name = "pictureBox251";
            this.pictureBox251.Size = new System.Drawing.Size(10, 10);
            this.pictureBox251.TabIndex = 261;
            this.pictureBox251.TabStop = false;
            this.pictureBox251.Tag = "coinScore";
            // 
            // pictureBox252
            // 
            this.pictureBox252.BackColor = System.Drawing.Color.Orange;
            this.pictureBox252.Location = new System.Drawing.Point(978, 307);
            this.pictureBox252.Name = "pictureBox252";
            this.pictureBox252.Size = new System.Drawing.Size(10, 10);
            this.pictureBox252.TabIndex = 260;
            this.pictureBox252.TabStop = false;
            this.pictureBox252.Tag = "coinScore";
            // 
            // pictureBox253
            // 
            this.pictureBox253.BackColor = System.Drawing.Color.Orange;
            this.pictureBox253.Location = new System.Drawing.Point(998, 307);
            this.pictureBox253.Name = "pictureBox253";
            this.pictureBox253.Size = new System.Drawing.Size(10, 10);
            this.pictureBox253.TabIndex = 259;
            this.pictureBox253.TabStop = false;
            this.pictureBox253.Tag = "coinScore";
            // 
            // pictureBox254
            // 
            this.pictureBox254.BackColor = System.Drawing.Color.Orange;
            this.pictureBox254.Location = new System.Drawing.Point(1023, 307);
            this.pictureBox254.Name = "pictureBox254";
            this.pictureBox254.Size = new System.Drawing.Size(10, 10);
            this.pictureBox254.TabIndex = 258;
            this.pictureBox254.TabStop = false;
            this.pictureBox254.Tag = "coinScore";
            // 
            // pictureBox255
            // 
            this.pictureBox255.BackColor = System.Drawing.Color.Orange;
            this.pictureBox255.Location = new System.Drawing.Point(1048, 307);
            this.pictureBox255.Name = "pictureBox255";
            this.pictureBox255.Size = new System.Drawing.Size(10, 10);
            this.pictureBox255.TabIndex = 257;
            this.pictureBox255.TabStop = false;
            this.pictureBox255.Tag = "coinScore";
            // 
            // pictureBox256
            // 
            this.pictureBox256.BackColor = System.Drawing.Color.Orange;
            this.pictureBox256.Location = new System.Drawing.Point(1073, 307);
            this.pictureBox256.Name = "pictureBox256";
            this.pictureBox256.Size = new System.Drawing.Size(10, 10);
            this.pictureBox256.TabIndex = 256;
            this.pictureBox256.TabStop = false;
            this.pictureBox256.Tag = "coinScore";
            // 
            // pictureBox257
            // 
            this.pictureBox257.BackColor = System.Drawing.Color.Orange;
            this.pictureBox257.Location = new System.Drawing.Point(1095, 307);
            this.pictureBox257.Name = "pictureBox257";
            this.pictureBox257.Size = new System.Drawing.Size(10, 10);
            this.pictureBox257.TabIndex = 255;
            this.pictureBox257.TabStop = false;
            this.pictureBox257.Tag = "coinScore";
            // 
            // pictureBox258
            // 
            this.pictureBox258.BackColor = System.Drawing.Color.Orange;
            this.pictureBox258.Location = new System.Drawing.Point(1118, 307);
            this.pictureBox258.Name = "pictureBox258";
            this.pictureBox258.Size = new System.Drawing.Size(10, 10);
            this.pictureBox258.TabIndex = 254;
            this.pictureBox258.TabStop = false;
            this.pictureBox258.Tag = "coinScore";
            // 
            // pictureBox259
            // 
            this.pictureBox259.BackColor = System.Drawing.Color.Orange;
            this.pictureBox259.Location = new System.Drawing.Point(1143, 307);
            this.pictureBox259.Name = "pictureBox259";
            this.pictureBox259.Size = new System.Drawing.Size(10, 10);
            this.pictureBox259.TabIndex = 253;
            this.pictureBox259.TabStop = false;
            this.pictureBox259.Tag = "coinScore";
            // 
            // pictureBox260
            // 
            this.pictureBox260.BackColor = System.Drawing.Color.Orange;
            this.pictureBox260.Location = new System.Drawing.Point(1168, 307);
            this.pictureBox260.Name = "pictureBox260";
            this.pictureBox260.Size = new System.Drawing.Size(10, 10);
            this.pictureBox260.TabIndex = 252;
            this.pictureBox260.TabStop = false;
            this.pictureBox260.Tag = "coinScore";
            // 
            // pictureBox261
            // 
            this.pictureBox261.BackColor = System.Drawing.Color.Orange;
            this.pictureBox261.Location = new System.Drawing.Point(1193, 307);
            this.pictureBox261.Name = "pictureBox261";
            this.pictureBox261.Size = new System.Drawing.Size(10, 10);
            this.pictureBox261.TabIndex = 251;
            this.pictureBox261.TabStop = false;
            this.pictureBox261.Tag = "coinScore";
            // 
            // pictureBox262
            // 
            this.pictureBox262.BackColor = System.Drawing.Color.Orange;
            this.pictureBox262.Location = new System.Drawing.Point(1215, 307);
            this.pictureBox262.Name = "pictureBox262";
            this.pictureBox262.Size = new System.Drawing.Size(10, 10);
            this.pictureBox262.TabIndex = 250;
            this.pictureBox262.TabStop = false;
            this.pictureBox262.Tag = "coinScore";
            // 
            // pictureBox263
            // 
            this.pictureBox263.BackColor = System.Drawing.Color.Orange;
            this.pictureBox263.Location = new System.Drawing.Point(1240, 307);
            this.pictureBox263.Name = "pictureBox263";
            this.pictureBox263.Size = new System.Drawing.Size(10, 10);
            this.pictureBox263.TabIndex = 249;
            this.pictureBox263.TabStop = false;
            this.pictureBox263.Tag = "coinScore";
            // 
            // pictureBox264
            // 
            this.pictureBox264.BackColor = System.Drawing.Color.Orange;
            this.pictureBox264.Location = new System.Drawing.Point(1262, 307);
            this.pictureBox264.Name = "pictureBox264";
            this.pictureBox264.Size = new System.Drawing.Size(10, 10);
            this.pictureBox264.TabIndex = 248;
            this.pictureBox264.TabStop = false;
            this.pictureBox264.Tag = "coinScore";
            // 
            // pictureBox265
            // 
            this.pictureBox265.BackColor = System.Drawing.Color.Orange;
            this.pictureBox265.Location = new System.Drawing.Point(849, 243);
            this.pictureBox265.Name = "pictureBox265";
            this.pictureBox265.Size = new System.Drawing.Size(10, 10);
            this.pictureBox265.TabIndex = 283;
            this.pictureBox265.TabStop = false;
            this.pictureBox265.Tag = "coinScore";
            // 
            // pictureBox266
            // 
            this.pictureBox266.BackColor = System.Drawing.Color.Orange;
            this.pictureBox266.Location = new System.Drawing.Point(872, 243);
            this.pictureBox266.Name = "pictureBox266";
            this.pictureBox266.Size = new System.Drawing.Size(10, 10);
            this.pictureBox266.TabIndex = 282;
            this.pictureBox266.TabStop = false;
            this.pictureBox266.Tag = "coinScore";
            // 
            // pictureBox267
            // 
            this.pictureBox267.BackColor = System.Drawing.Color.Orange;
            this.pictureBox267.Location = new System.Drawing.Point(897, 243);
            this.pictureBox267.Name = "pictureBox267";
            this.pictureBox267.Size = new System.Drawing.Size(10, 10);
            this.pictureBox267.TabIndex = 281;
            this.pictureBox267.TabStop = false;
            this.pictureBox267.Tag = "coinScore";
            // 
            // pictureBox268
            // 
            this.pictureBox268.BackColor = System.Drawing.Color.Orange;
            this.pictureBox268.Location = new System.Drawing.Point(922, 243);
            this.pictureBox268.Name = "pictureBox268";
            this.pictureBox268.Size = new System.Drawing.Size(10, 10);
            this.pictureBox268.TabIndex = 280;
            this.pictureBox268.TabStop = false;
            this.pictureBox268.Tag = "coinScore";
            // 
            // pictureBox269
            // 
            this.pictureBox269.BackColor = System.Drawing.Color.Orange;
            this.pictureBox269.Location = new System.Drawing.Point(947, 243);
            this.pictureBox269.Name = "pictureBox269";
            this.pictureBox269.Size = new System.Drawing.Size(10, 10);
            this.pictureBox269.TabIndex = 279;
            this.pictureBox269.TabStop = false;
            this.pictureBox269.Tag = "coinScore";
            // 
            // pictureBox270
            // 
            this.pictureBox270.BackColor = System.Drawing.Color.Orange;
            this.pictureBox270.Location = new System.Drawing.Point(969, 243);
            this.pictureBox270.Name = "pictureBox270";
            this.pictureBox270.Size = new System.Drawing.Size(10, 10);
            this.pictureBox270.TabIndex = 278;
            this.pictureBox270.TabStop = false;
            this.pictureBox270.Tag = "coinScore";
            // 
            // pictureBox271
            // 
            this.pictureBox271.BackColor = System.Drawing.Color.Orange;
            this.pictureBox271.Location = new System.Drawing.Point(989, 243);
            this.pictureBox271.Name = "pictureBox271";
            this.pictureBox271.Size = new System.Drawing.Size(10, 10);
            this.pictureBox271.TabIndex = 277;
            this.pictureBox271.TabStop = false;
            this.pictureBox271.Tag = "coinScore";
            // 
            // pictureBox272
            // 
            this.pictureBox272.BackColor = System.Drawing.Color.Orange;
            this.pictureBox272.Location = new System.Drawing.Point(1014, 243);
            this.pictureBox272.Name = "pictureBox272";
            this.pictureBox272.Size = new System.Drawing.Size(10, 10);
            this.pictureBox272.TabIndex = 276;
            this.pictureBox272.TabStop = false;
            this.pictureBox272.Tag = "coinScore";
            // 
            // pictureBox273
            // 
            this.pictureBox273.BackColor = System.Drawing.Color.Orange;
            this.pictureBox273.Location = new System.Drawing.Point(1039, 243);
            this.pictureBox273.Name = "pictureBox273";
            this.pictureBox273.Size = new System.Drawing.Size(10, 10);
            this.pictureBox273.TabIndex = 275;
            this.pictureBox273.TabStop = false;
            this.pictureBox273.Tag = "coinScore";
            // 
            // pictureBox274
            // 
            this.pictureBox274.BackColor = System.Drawing.Color.Orange;
            this.pictureBox274.Location = new System.Drawing.Point(1064, 243);
            this.pictureBox274.Name = "pictureBox274";
            this.pictureBox274.Size = new System.Drawing.Size(10, 10);
            this.pictureBox274.TabIndex = 274;
            this.pictureBox274.TabStop = false;
            this.pictureBox274.Tag = "coinScore";
            // 
            // pictureBox275
            // 
            this.pictureBox275.BackColor = System.Drawing.Color.Orange;
            this.pictureBox275.Location = new System.Drawing.Point(1086, 243);
            this.pictureBox275.Name = "pictureBox275";
            this.pictureBox275.Size = new System.Drawing.Size(10, 10);
            this.pictureBox275.TabIndex = 273;
            this.pictureBox275.TabStop = false;
            this.pictureBox275.Tag = "coinScore";
            // 
            // pictureBox276
            // 
            this.pictureBox276.BackColor = System.Drawing.Color.Orange;
            this.pictureBox276.Location = new System.Drawing.Point(1109, 243);
            this.pictureBox276.Name = "pictureBox276";
            this.pictureBox276.Size = new System.Drawing.Size(10, 10);
            this.pictureBox276.TabIndex = 272;
            this.pictureBox276.TabStop = false;
            this.pictureBox276.Tag = "coinScore";
            // 
            // pictureBox277
            // 
            this.pictureBox277.BackColor = System.Drawing.Color.Orange;
            this.pictureBox277.Location = new System.Drawing.Point(1134, 243);
            this.pictureBox277.Name = "pictureBox277";
            this.pictureBox277.Size = new System.Drawing.Size(10, 10);
            this.pictureBox277.TabIndex = 271;
            this.pictureBox277.TabStop = false;
            this.pictureBox277.Tag = "coinScore";
            // 
            // pictureBox278
            // 
            this.pictureBox278.BackColor = System.Drawing.Color.Orange;
            this.pictureBox278.Location = new System.Drawing.Point(1159, 243);
            this.pictureBox278.Name = "pictureBox278";
            this.pictureBox278.Size = new System.Drawing.Size(10, 10);
            this.pictureBox278.TabIndex = 270;
            this.pictureBox278.TabStop = false;
            this.pictureBox278.Tag = "coinScore";
            // 
            // pictureBox279
            // 
            this.pictureBox279.BackColor = System.Drawing.Color.Orange;
            this.pictureBox279.Location = new System.Drawing.Point(1184, 243);
            this.pictureBox279.Name = "pictureBox279";
            this.pictureBox279.Size = new System.Drawing.Size(10, 10);
            this.pictureBox279.TabIndex = 269;
            this.pictureBox279.TabStop = false;
            this.pictureBox279.Tag = "coinScore";
            this.pictureBox279.Click += new System.EventHandler(this.pictureBox279_Click);
            // 
            // pictureBox280
            // 
            this.pictureBox280.BackColor = System.Drawing.Color.Orange;
            this.pictureBox280.Location = new System.Drawing.Point(1206, 243);
            this.pictureBox280.Name = "pictureBox280";
            this.pictureBox280.Size = new System.Drawing.Size(10, 10);
            this.pictureBox280.TabIndex = 268;
            this.pictureBox280.TabStop = false;
            this.pictureBox280.Tag = "coinScore";
            // 
            // pictureBox281
            // 
            this.pictureBox281.BackColor = System.Drawing.Color.Orange;
            this.pictureBox281.Location = new System.Drawing.Point(1231, 243);
            this.pictureBox281.Name = "pictureBox281";
            this.pictureBox281.Size = new System.Drawing.Size(10, 10);
            this.pictureBox281.TabIndex = 267;
            this.pictureBox281.TabStop = false;
            this.pictureBox281.Tag = "coinScore";
            // 
            // pictureBox282
            // 
            this.pictureBox282.BackColor = System.Drawing.Color.Orange;
            this.pictureBox282.Location = new System.Drawing.Point(1253, 243);
            this.pictureBox282.Name = "pictureBox282";
            this.pictureBox282.Size = new System.Drawing.Size(10, 10);
            this.pictureBox282.TabIndex = 266;
            this.pictureBox282.TabStop = false;
            this.pictureBox282.Tag = "coinScore";
            // 
            // pictureBox283
            // 
            this.pictureBox283.BackColor = System.Drawing.Color.Orange;
            this.pictureBox283.Location = new System.Drawing.Point(858, 176);
            this.pictureBox283.Name = "pictureBox283";
            this.pictureBox283.Size = new System.Drawing.Size(10, 10);
            this.pictureBox283.TabIndex = 301;
            this.pictureBox283.TabStop = false;
            this.pictureBox283.Tag = "coinScore";
            // 
            // pictureBox284
            // 
            this.pictureBox284.BackColor = System.Drawing.Color.Orange;
            this.pictureBox284.Location = new System.Drawing.Point(881, 176);
            this.pictureBox284.Name = "pictureBox284";
            this.pictureBox284.Size = new System.Drawing.Size(10, 10);
            this.pictureBox284.TabIndex = 300;
            this.pictureBox284.TabStop = false;
            this.pictureBox284.Tag = "coinScore";
            // 
            // pictureBox285
            // 
            this.pictureBox285.BackColor = System.Drawing.Color.Orange;
            this.pictureBox285.Location = new System.Drawing.Point(906, 176);
            this.pictureBox285.Name = "pictureBox285";
            this.pictureBox285.Size = new System.Drawing.Size(10, 10);
            this.pictureBox285.TabIndex = 299;
            this.pictureBox285.TabStop = false;
            this.pictureBox285.Tag = "coinScore";
            // 
            // pictureBox286
            // 
            this.pictureBox286.BackColor = System.Drawing.Color.Orange;
            this.pictureBox286.Location = new System.Drawing.Point(931, 176);
            this.pictureBox286.Name = "pictureBox286";
            this.pictureBox286.Size = new System.Drawing.Size(10, 10);
            this.pictureBox286.TabIndex = 298;
            this.pictureBox286.TabStop = false;
            this.pictureBox286.Tag = "coinScore";
            // 
            // pictureBox287
            // 
            this.pictureBox287.BackColor = System.Drawing.Color.Orange;
            this.pictureBox287.Location = new System.Drawing.Point(956, 176);
            this.pictureBox287.Name = "pictureBox287";
            this.pictureBox287.Size = new System.Drawing.Size(10, 10);
            this.pictureBox287.TabIndex = 297;
            this.pictureBox287.TabStop = false;
            this.pictureBox287.Tag = "coinScore";
            // 
            // pictureBox288
            // 
            this.pictureBox288.BackColor = System.Drawing.Color.Orange;
            this.pictureBox288.Location = new System.Drawing.Point(978, 176);
            this.pictureBox288.Name = "pictureBox288";
            this.pictureBox288.Size = new System.Drawing.Size(10, 10);
            this.pictureBox288.TabIndex = 296;
            this.pictureBox288.TabStop = false;
            this.pictureBox288.Tag = "coinScore";
            // 
            // pictureBox289
            // 
            this.pictureBox289.BackColor = System.Drawing.Color.Orange;
            this.pictureBox289.Location = new System.Drawing.Point(998, 176);
            this.pictureBox289.Name = "pictureBox289";
            this.pictureBox289.Size = new System.Drawing.Size(10, 10);
            this.pictureBox289.TabIndex = 295;
            this.pictureBox289.TabStop = false;
            this.pictureBox289.Tag = "coinScore";
            // 
            // pictureBox290
            // 
            this.pictureBox290.BackColor = System.Drawing.Color.Orange;
            this.pictureBox290.Location = new System.Drawing.Point(1023, 176);
            this.pictureBox290.Name = "pictureBox290";
            this.pictureBox290.Size = new System.Drawing.Size(10, 10);
            this.pictureBox290.TabIndex = 294;
            this.pictureBox290.TabStop = false;
            this.pictureBox290.Tag = "coinScore";
            // 
            // pictureBox291
            // 
            this.pictureBox291.BackColor = System.Drawing.Color.Orange;
            this.pictureBox291.Location = new System.Drawing.Point(1048, 176);
            this.pictureBox291.Name = "pictureBox291";
            this.pictureBox291.Size = new System.Drawing.Size(10, 10);
            this.pictureBox291.TabIndex = 293;
            this.pictureBox291.TabStop = false;
            this.pictureBox291.Tag = "coinScore";
            // 
            // pictureBox292
            // 
            this.pictureBox292.BackColor = System.Drawing.Color.Orange;
            this.pictureBox292.Location = new System.Drawing.Point(1073, 176);
            this.pictureBox292.Name = "pictureBox292";
            this.pictureBox292.Size = new System.Drawing.Size(10, 10);
            this.pictureBox292.TabIndex = 292;
            this.pictureBox292.TabStop = false;
            this.pictureBox292.Tag = "coinScore";
            // 
            // pictureBox293
            // 
            this.pictureBox293.BackColor = System.Drawing.Color.Orange;
            this.pictureBox293.Location = new System.Drawing.Point(1095, 176);
            this.pictureBox293.Name = "pictureBox293";
            this.pictureBox293.Size = new System.Drawing.Size(10, 10);
            this.pictureBox293.TabIndex = 291;
            this.pictureBox293.TabStop = false;
            this.pictureBox293.Tag = "coinScore";
            // 
            // pictureBox294
            // 
            this.pictureBox294.BackColor = System.Drawing.Color.Orange;
            this.pictureBox294.Location = new System.Drawing.Point(1118, 176);
            this.pictureBox294.Name = "pictureBox294";
            this.pictureBox294.Size = new System.Drawing.Size(10, 10);
            this.pictureBox294.TabIndex = 290;
            this.pictureBox294.TabStop = false;
            this.pictureBox294.Tag = "coinScore";
            // 
            // pictureBox295
            // 
            this.pictureBox295.BackColor = System.Drawing.Color.Orange;
            this.pictureBox295.Location = new System.Drawing.Point(1143, 176);
            this.pictureBox295.Name = "pictureBox295";
            this.pictureBox295.Size = new System.Drawing.Size(10, 10);
            this.pictureBox295.TabIndex = 289;
            this.pictureBox295.TabStop = false;
            this.pictureBox295.Tag = "coinScore";
            // 
            // pictureBox296
            // 
            this.pictureBox296.BackColor = System.Drawing.Color.Orange;
            this.pictureBox296.Location = new System.Drawing.Point(1168, 176);
            this.pictureBox296.Name = "pictureBox296";
            this.pictureBox296.Size = new System.Drawing.Size(10, 10);
            this.pictureBox296.TabIndex = 288;
            this.pictureBox296.TabStop = false;
            this.pictureBox296.Tag = "coinScore";
            // 
            // pictureBox297
            // 
            this.pictureBox297.BackColor = System.Drawing.Color.Orange;
            this.pictureBox297.Location = new System.Drawing.Point(1193, 176);
            this.pictureBox297.Name = "pictureBox297";
            this.pictureBox297.Size = new System.Drawing.Size(10, 10);
            this.pictureBox297.TabIndex = 287;
            this.pictureBox297.TabStop = false;
            this.pictureBox297.Tag = "coinScore";
            // 
            // pictureBox298
            // 
            this.pictureBox298.BackColor = System.Drawing.Color.Orange;
            this.pictureBox298.Location = new System.Drawing.Point(1215, 176);
            this.pictureBox298.Name = "pictureBox298";
            this.pictureBox298.Size = new System.Drawing.Size(10, 10);
            this.pictureBox298.TabIndex = 286;
            this.pictureBox298.TabStop = false;
            this.pictureBox298.Tag = "coinScore";
            // 
            // pictureBox299
            // 
            this.pictureBox299.BackColor = System.Drawing.Color.Orange;
            this.pictureBox299.Location = new System.Drawing.Point(1240, 176);
            this.pictureBox299.Name = "pictureBox299";
            this.pictureBox299.Size = new System.Drawing.Size(10, 10);
            this.pictureBox299.TabIndex = 285;
            this.pictureBox299.TabStop = false;
            this.pictureBox299.Tag = "coinScore";
            // 
            // pictureBox300
            // 
            this.pictureBox300.BackColor = System.Drawing.Color.Orange;
            this.pictureBox300.Location = new System.Drawing.Point(1262, 176);
            this.pictureBox300.Name = "pictureBox300";
            this.pictureBox300.Size = new System.Drawing.Size(10, 10);
            this.pictureBox300.TabIndex = 284;
            this.pictureBox300.TabStop = false;
            this.pictureBox300.Tag = "coinScore";
            // 
            // pictureBox301
            // 
            this.pictureBox301.BackColor = System.Drawing.Color.Orange;
            this.pictureBox301.Location = new System.Drawing.Point(849, 108);
            this.pictureBox301.Name = "pictureBox301";
            this.pictureBox301.Size = new System.Drawing.Size(10, 10);
            this.pictureBox301.TabIndex = 319;
            this.pictureBox301.TabStop = false;
            this.pictureBox301.Tag = "coinScore";
            // 
            // pictureBox302
            // 
            this.pictureBox302.BackColor = System.Drawing.Color.Orange;
            this.pictureBox302.Location = new System.Drawing.Point(872, 108);
            this.pictureBox302.Name = "pictureBox302";
            this.pictureBox302.Size = new System.Drawing.Size(10, 10);
            this.pictureBox302.TabIndex = 318;
            this.pictureBox302.TabStop = false;
            this.pictureBox302.Tag = "coinScore";
            // 
            // pictureBox303
            // 
            this.pictureBox303.BackColor = System.Drawing.Color.Orange;
            this.pictureBox303.Location = new System.Drawing.Point(897, 108);
            this.pictureBox303.Name = "pictureBox303";
            this.pictureBox303.Size = new System.Drawing.Size(10, 10);
            this.pictureBox303.TabIndex = 317;
            this.pictureBox303.TabStop = false;
            this.pictureBox303.Tag = "coinScore";
            // 
            // pictureBox304
            // 
            this.pictureBox304.BackColor = System.Drawing.Color.Orange;
            this.pictureBox304.Location = new System.Drawing.Point(922, 108);
            this.pictureBox304.Name = "pictureBox304";
            this.pictureBox304.Size = new System.Drawing.Size(10, 10);
            this.pictureBox304.TabIndex = 316;
            this.pictureBox304.TabStop = false;
            this.pictureBox304.Tag = "coinScore";
            // 
            // pictureBox305
            // 
            this.pictureBox305.BackColor = System.Drawing.Color.Orange;
            this.pictureBox305.Location = new System.Drawing.Point(947, 108);
            this.pictureBox305.Name = "pictureBox305";
            this.pictureBox305.Size = new System.Drawing.Size(10, 10);
            this.pictureBox305.TabIndex = 315;
            this.pictureBox305.TabStop = false;
            this.pictureBox305.Tag = "coinScore";
            // 
            // pictureBox306
            // 
            this.pictureBox306.BackColor = System.Drawing.Color.Orange;
            this.pictureBox306.Location = new System.Drawing.Point(969, 108);
            this.pictureBox306.Name = "pictureBox306";
            this.pictureBox306.Size = new System.Drawing.Size(10, 10);
            this.pictureBox306.TabIndex = 314;
            this.pictureBox306.TabStop = false;
            this.pictureBox306.Tag = "coinScore";
            // 
            // pictureBox307
            // 
            this.pictureBox307.BackColor = System.Drawing.Color.Orange;
            this.pictureBox307.Location = new System.Drawing.Point(989, 108);
            this.pictureBox307.Name = "pictureBox307";
            this.pictureBox307.Size = new System.Drawing.Size(10, 10);
            this.pictureBox307.TabIndex = 313;
            this.pictureBox307.TabStop = false;
            this.pictureBox307.Tag = "coinScore";
            // 
            // pictureBox308
            // 
            this.pictureBox308.BackColor = System.Drawing.Color.Orange;
            this.pictureBox308.Location = new System.Drawing.Point(1014, 108);
            this.pictureBox308.Name = "pictureBox308";
            this.pictureBox308.Size = new System.Drawing.Size(10, 10);
            this.pictureBox308.TabIndex = 312;
            this.pictureBox308.TabStop = false;
            this.pictureBox308.Tag = "coinScore";
            // 
            // pictureBox309
            // 
            this.pictureBox309.BackColor = System.Drawing.Color.Orange;
            this.pictureBox309.Location = new System.Drawing.Point(1039, 108);
            this.pictureBox309.Name = "pictureBox309";
            this.pictureBox309.Size = new System.Drawing.Size(10, 10);
            this.pictureBox309.TabIndex = 311;
            this.pictureBox309.TabStop = false;
            this.pictureBox309.Tag = "coinScore";
            // 
            // pictureBox310
            // 
            this.pictureBox310.BackColor = System.Drawing.Color.Orange;
            this.pictureBox310.Location = new System.Drawing.Point(1064, 108);
            this.pictureBox310.Name = "pictureBox310";
            this.pictureBox310.Size = new System.Drawing.Size(10, 10);
            this.pictureBox310.TabIndex = 310;
            this.pictureBox310.TabStop = false;
            this.pictureBox310.Tag = "coinScore";
            // 
            // pictureBox311
            // 
            this.pictureBox311.BackColor = System.Drawing.Color.Orange;
            this.pictureBox311.Location = new System.Drawing.Point(1086, 108);
            this.pictureBox311.Name = "pictureBox311";
            this.pictureBox311.Size = new System.Drawing.Size(10, 10);
            this.pictureBox311.TabIndex = 309;
            this.pictureBox311.TabStop = false;
            this.pictureBox311.Tag = "coinScore";
            // 
            // pictureBox312
            // 
            this.pictureBox312.BackColor = System.Drawing.Color.Orange;
            this.pictureBox312.Location = new System.Drawing.Point(1109, 108);
            this.pictureBox312.Name = "pictureBox312";
            this.pictureBox312.Size = new System.Drawing.Size(10, 10);
            this.pictureBox312.TabIndex = 308;
            this.pictureBox312.TabStop = false;
            this.pictureBox312.Tag = "coinScore";
            // 
            // pictureBox313
            // 
            this.pictureBox313.BackColor = System.Drawing.Color.Orange;
            this.pictureBox313.Location = new System.Drawing.Point(1134, 108);
            this.pictureBox313.Name = "pictureBox313";
            this.pictureBox313.Size = new System.Drawing.Size(10, 10);
            this.pictureBox313.TabIndex = 307;
            this.pictureBox313.TabStop = false;
            this.pictureBox313.Tag = "coinScore";
            // 
            // pictureBox314
            // 
            this.pictureBox314.BackColor = System.Drawing.Color.Orange;
            this.pictureBox314.Location = new System.Drawing.Point(1159, 108);
            this.pictureBox314.Name = "pictureBox314";
            this.pictureBox314.Size = new System.Drawing.Size(10, 10);
            this.pictureBox314.TabIndex = 306;
            this.pictureBox314.TabStop = false;
            this.pictureBox314.Tag = "coinScore";
            // 
            // pictureBox315
            // 
            this.pictureBox315.BackColor = System.Drawing.Color.Orange;
            this.pictureBox315.Location = new System.Drawing.Point(1184, 108);
            this.pictureBox315.Name = "pictureBox315";
            this.pictureBox315.Size = new System.Drawing.Size(10, 10);
            this.pictureBox315.TabIndex = 305;
            this.pictureBox315.TabStop = false;
            this.pictureBox315.Tag = "coinScore";
            // 
            // pictureBox316
            // 
            this.pictureBox316.BackColor = System.Drawing.Color.Orange;
            this.pictureBox316.Location = new System.Drawing.Point(1206, 108);
            this.pictureBox316.Name = "pictureBox316";
            this.pictureBox316.Size = new System.Drawing.Size(10, 10);
            this.pictureBox316.TabIndex = 304;
            this.pictureBox316.TabStop = false;
            this.pictureBox316.Tag = "coinScore";
            // 
            // pictureBox317
            // 
            this.pictureBox317.BackColor = System.Drawing.Color.Orange;
            this.pictureBox317.Location = new System.Drawing.Point(1231, 108);
            this.pictureBox317.Name = "pictureBox317";
            this.pictureBox317.Size = new System.Drawing.Size(10, 10);
            this.pictureBox317.TabIndex = 303;
            this.pictureBox317.TabStop = false;
            this.pictureBox317.Tag = "coinScore";
            // 
            // pictureBox318
            // 
            this.pictureBox318.BackColor = System.Drawing.Color.Orange;
            this.pictureBox318.Location = new System.Drawing.Point(1253, 108);
            this.pictureBox318.Name = "pictureBox318";
            this.pictureBox318.Size = new System.Drawing.Size(10, 10);
            this.pictureBox318.TabIndex = 302;
            this.pictureBox318.TabStop = false;
            this.pictureBox318.Tag = "coinScore";
            // 
            // pictureBox319
            // 
            this.pictureBox319.BackColor = System.Drawing.Color.Orange;
            this.pictureBox319.Location = new System.Drawing.Point(74, 108);
            this.pictureBox319.Name = "pictureBox319";
            this.pictureBox319.Size = new System.Drawing.Size(10, 10);
            this.pictureBox319.TabIndex = 337;
            this.pictureBox319.TabStop = false;
            this.pictureBox319.Tag = "coinScore";
            // 
            // pictureBox320
            // 
            this.pictureBox320.BackColor = System.Drawing.Color.Orange;
            this.pictureBox320.Location = new System.Drawing.Point(97, 108);
            this.pictureBox320.Name = "pictureBox320";
            this.pictureBox320.Size = new System.Drawing.Size(10, 10);
            this.pictureBox320.TabIndex = 336;
            this.pictureBox320.TabStop = false;
            this.pictureBox320.Tag = "coinScore";
            // 
            // pictureBox321
            // 
            this.pictureBox321.BackColor = System.Drawing.Color.Orange;
            this.pictureBox321.Location = new System.Drawing.Point(122, 108);
            this.pictureBox321.Name = "pictureBox321";
            this.pictureBox321.Size = new System.Drawing.Size(10, 10);
            this.pictureBox321.TabIndex = 335;
            this.pictureBox321.TabStop = false;
            this.pictureBox321.Tag = "coinScore";
            // 
            // pictureBox322
            // 
            this.pictureBox322.BackColor = System.Drawing.Color.Orange;
            this.pictureBox322.Location = new System.Drawing.Point(147, 108);
            this.pictureBox322.Name = "pictureBox322";
            this.pictureBox322.Size = new System.Drawing.Size(10, 10);
            this.pictureBox322.TabIndex = 334;
            this.pictureBox322.TabStop = false;
            this.pictureBox322.Tag = "coinScore";
            // 
            // pictureBox323
            // 
            this.pictureBox323.BackColor = System.Drawing.Color.Orange;
            this.pictureBox323.Location = new System.Drawing.Point(172, 108);
            this.pictureBox323.Name = "pictureBox323";
            this.pictureBox323.Size = new System.Drawing.Size(10, 10);
            this.pictureBox323.TabIndex = 333;
            this.pictureBox323.TabStop = false;
            this.pictureBox323.Tag = "coinScore";
            // 
            // pictureBox324
            // 
            this.pictureBox324.BackColor = System.Drawing.Color.Orange;
            this.pictureBox324.Location = new System.Drawing.Point(194, 108);
            this.pictureBox324.Name = "pictureBox324";
            this.pictureBox324.Size = new System.Drawing.Size(10, 10);
            this.pictureBox324.TabIndex = 332;
            this.pictureBox324.TabStop = false;
            this.pictureBox324.Tag = "coinScore";
            // 
            // pictureBox325
            // 
            this.pictureBox325.BackColor = System.Drawing.Color.Orange;
            this.pictureBox325.Location = new System.Drawing.Point(214, 108);
            this.pictureBox325.Name = "pictureBox325";
            this.pictureBox325.Size = new System.Drawing.Size(10, 10);
            this.pictureBox325.TabIndex = 331;
            this.pictureBox325.TabStop = false;
            this.pictureBox325.Tag = "coinScore";
            // 
            // pictureBox326
            // 
            this.pictureBox326.BackColor = System.Drawing.Color.Orange;
            this.pictureBox326.Location = new System.Drawing.Point(239, 108);
            this.pictureBox326.Name = "pictureBox326";
            this.pictureBox326.Size = new System.Drawing.Size(10, 10);
            this.pictureBox326.TabIndex = 330;
            this.pictureBox326.TabStop = false;
            this.pictureBox326.Tag = "coinScore";
            // 
            // pictureBox327
            // 
            this.pictureBox327.BackColor = System.Drawing.Color.Orange;
            this.pictureBox327.Location = new System.Drawing.Point(264, 108);
            this.pictureBox327.Name = "pictureBox327";
            this.pictureBox327.Size = new System.Drawing.Size(10, 10);
            this.pictureBox327.TabIndex = 329;
            this.pictureBox327.TabStop = false;
            this.pictureBox327.Tag = "coinScore";
            // 
            // pictureBox328
            // 
            this.pictureBox328.BackColor = System.Drawing.Color.Orange;
            this.pictureBox328.Location = new System.Drawing.Point(289, 108);
            this.pictureBox328.Name = "pictureBox328";
            this.pictureBox328.Size = new System.Drawing.Size(10, 10);
            this.pictureBox328.TabIndex = 328;
            this.pictureBox328.TabStop = false;
            this.pictureBox328.Tag = "coinScore";
            // 
            // pictureBox329
            // 
            this.pictureBox329.BackColor = System.Drawing.Color.Orange;
            this.pictureBox329.Location = new System.Drawing.Point(311, 108);
            this.pictureBox329.Name = "pictureBox329";
            this.pictureBox329.Size = new System.Drawing.Size(10, 10);
            this.pictureBox329.TabIndex = 327;
            this.pictureBox329.TabStop = false;
            this.pictureBox329.Tag = "coinScore";
            // 
            // pictureBox330
            // 
            this.pictureBox330.BackColor = System.Drawing.Color.Orange;
            this.pictureBox330.Location = new System.Drawing.Point(334, 108);
            this.pictureBox330.Name = "pictureBox330";
            this.pictureBox330.Size = new System.Drawing.Size(10, 10);
            this.pictureBox330.TabIndex = 326;
            this.pictureBox330.TabStop = false;
            this.pictureBox330.Tag = "coinScore";
            // 
            // pictureBox331
            // 
            this.pictureBox331.BackColor = System.Drawing.Color.Orange;
            this.pictureBox331.Location = new System.Drawing.Point(359, 108);
            this.pictureBox331.Name = "pictureBox331";
            this.pictureBox331.Size = new System.Drawing.Size(10, 10);
            this.pictureBox331.TabIndex = 325;
            this.pictureBox331.TabStop = false;
            this.pictureBox331.Tag = "coinScore";
            // 
            // pictureBox332
            // 
            this.pictureBox332.BackColor = System.Drawing.Color.Orange;
            this.pictureBox332.Location = new System.Drawing.Point(384, 108);
            this.pictureBox332.Name = "pictureBox332";
            this.pictureBox332.Size = new System.Drawing.Size(10, 10);
            this.pictureBox332.TabIndex = 324;
            this.pictureBox332.TabStop = false;
            this.pictureBox332.Tag = "coinScore";
            // 
            // pictureBox333
            // 
            this.pictureBox333.BackColor = System.Drawing.Color.Orange;
            this.pictureBox333.Location = new System.Drawing.Point(409, 108);
            this.pictureBox333.Name = "pictureBox333";
            this.pictureBox333.Size = new System.Drawing.Size(10, 10);
            this.pictureBox333.TabIndex = 323;
            this.pictureBox333.TabStop = false;
            this.pictureBox333.Tag = "coinScore";
            // 
            // pictureBox334
            // 
            this.pictureBox334.BackColor = System.Drawing.Color.Orange;
            this.pictureBox334.Location = new System.Drawing.Point(431, 108);
            this.pictureBox334.Name = "pictureBox334";
            this.pictureBox334.Size = new System.Drawing.Size(10, 10);
            this.pictureBox334.TabIndex = 322;
            this.pictureBox334.TabStop = false;
            this.pictureBox334.Tag = "coinScore";
            // 
            // pictureBox335
            // 
            this.pictureBox335.BackColor = System.Drawing.Color.Orange;
            this.pictureBox335.Location = new System.Drawing.Point(456, 108);
            this.pictureBox335.Name = "pictureBox335";
            this.pictureBox335.Size = new System.Drawing.Size(10, 10);
            this.pictureBox335.TabIndex = 321;
            this.pictureBox335.TabStop = false;
            this.pictureBox335.Tag = "coinScore";
            // 
            // pictureBox336
            // 
            this.pictureBox336.BackColor = System.Drawing.Color.Orange;
            this.pictureBox336.Location = new System.Drawing.Point(478, 108);
            this.pictureBox336.Name = "pictureBox336";
            this.pictureBox336.Size = new System.Drawing.Size(10, 10);
            this.pictureBox336.TabIndex = 320;
            this.pictureBox336.TabStop = false;
            this.pictureBox336.Tag = "coinScore";
            // 
            // pictureBox337
            // 
            this.pictureBox337.BackColor = System.Drawing.Color.Orange;
            this.pictureBox337.Location = new System.Drawing.Point(74, 176);
            this.pictureBox337.Name = "pictureBox337";
            this.pictureBox337.Size = new System.Drawing.Size(10, 10);
            this.pictureBox337.TabIndex = 355;
            this.pictureBox337.TabStop = false;
            this.pictureBox337.Tag = "coinScore";
            // 
            // pictureBox338
            // 
            this.pictureBox338.BackColor = System.Drawing.Color.Orange;
            this.pictureBox338.Location = new System.Drawing.Point(97, 176);
            this.pictureBox338.Name = "pictureBox338";
            this.pictureBox338.Size = new System.Drawing.Size(10, 10);
            this.pictureBox338.TabIndex = 354;
            this.pictureBox338.TabStop = false;
            this.pictureBox338.Tag = "coinScore";
            // 
            // pictureBox339
            // 
            this.pictureBox339.BackColor = System.Drawing.Color.Orange;
            this.pictureBox339.Location = new System.Drawing.Point(122, 176);
            this.pictureBox339.Name = "pictureBox339";
            this.pictureBox339.Size = new System.Drawing.Size(10, 10);
            this.pictureBox339.TabIndex = 353;
            this.pictureBox339.TabStop = false;
            this.pictureBox339.Tag = "coinScore";
            // 
            // pictureBox340
            // 
            this.pictureBox340.BackColor = System.Drawing.Color.Orange;
            this.pictureBox340.Location = new System.Drawing.Point(147, 176);
            this.pictureBox340.Name = "pictureBox340";
            this.pictureBox340.Size = new System.Drawing.Size(10, 10);
            this.pictureBox340.TabIndex = 352;
            this.pictureBox340.TabStop = false;
            this.pictureBox340.Tag = "coinScore";
            // 
            // pictureBox341
            // 
            this.pictureBox341.BackColor = System.Drawing.Color.Orange;
            this.pictureBox341.Location = new System.Drawing.Point(172, 176);
            this.pictureBox341.Name = "pictureBox341";
            this.pictureBox341.Size = new System.Drawing.Size(10, 10);
            this.pictureBox341.TabIndex = 351;
            this.pictureBox341.TabStop = false;
            this.pictureBox341.Tag = "coinScore";
            // 
            // pictureBox342
            // 
            this.pictureBox342.BackColor = System.Drawing.Color.Orange;
            this.pictureBox342.Location = new System.Drawing.Point(194, 176);
            this.pictureBox342.Name = "pictureBox342";
            this.pictureBox342.Size = new System.Drawing.Size(10, 10);
            this.pictureBox342.TabIndex = 350;
            this.pictureBox342.TabStop = false;
            this.pictureBox342.Tag = "coinScore";
            // 
            // pictureBox343
            // 
            this.pictureBox343.BackColor = System.Drawing.Color.Orange;
            this.pictureBox343.Location = new System.Drawing.Point(214, 176);
            this.pictureBox343.Name = "pictureBox343";
            this.pictureBox343.Size = new System.Drawing.Size(10, 10);
            this.pictureBox343.TabIndex = 349;
            this.pictureBox343.TabStop = false;
            this.pictureBox343.Tag = "coinScore";
            // 
            // pictureBox344
            // 
            this.pictureBox344.BackColor = System.Drawing.Color.Orange;
            this.pictureBox344.Location = new System.Drawing.Point(239, 176);
            this.pictureBox344.Name = "pictureBox344";
            this.pictureBox344.Size = new System.Drawing.Size(10, 10);
            this.pictureBox344.TabIndex = 348;
            this.pictureBox344.TabStop = false;
            this.pictureBox344.Tag = "coinScore";
            // 
            // pictureBox345
            // 
            this.pictureBox345.BackColor = System.Drawing.Color.Orange;
            this.pictureBox345.Location = new System.Drawing.Point(264, 176);
            this.pictureBox345.Name = "pictureBox345";
            this.pictureBox345.Size = new System.Drawing.Size(10, 10);
            this.pictureBox345.TabIndex = 347;
            this.pictureBox345.TabStop = false;
            this.pictureBox345.Tag = "coinScore";
            // 
            // pictureBox346
            // 
            this.pictureBox346.BackColor = System.Drawing.Color.Orange;
            this.pictureBox346.Location = new System.Drawing.Point(289, 176);
            this.pictureBox346.Name = "pictureBox346";
            this.pictureBox346.Size = new System.Drawing.Size(10, 10);
            this.pictureBox346.TabIndex = 346;
            this.pictureBox346.TabStop = false;
            this.pictureBox346.Tag = "coinScore";
            // 
            // pictureBox347
            // 
            this.pictureBox347.BackColor = System.Drawing.Color.Orange;
            this.pictureBox347.Location = new System.Drawing.Point(311, 176);
            this.pictureBox347.Name = "pictureBox347";
            this.pictureBox347.Size = new System.Drawing.Size(10, 10);
            this.pictureBox347.TabIndex = 345;
            this.pictureBox347.TabStop = false;
            this.pictureBox347.Tag = "coinScore";
            // 
            // pictureBox348
            // 
            this.pictureBox348.BackColor = System.Drawing.Color.Orange;
            this.pictureBox348.Location = new System.Drawing.Point(334, 176);
            this.pictureBox348.Name = "pictureBox348";
            this.pictureBox348.Size = new System.Drawing.Size(10, 10);
            this.pictureBox348.TabIndex = 344;
            this.pictureBox348.TabStop = false;
            this.pictureBox348.Tag = "coinScore";
            // 
            // pictureBox349
            // 
            this.pictureBox349.BackColor = System.Drawing.Color.Orange;
            this.pictureBox349.Location = new System.Drawing.Point(359, 176);
            this.pictureBox349.Name = "pictureBox349";
            this.pictureBox349.Size = new System.Drawing.Size(10, 10);
            this.pictureBox349.TabIndex = 343;
            this.pictureBox349.TabStop = false;
            this.pictureBox349.Tag = "coinScore";
            // 
            // pictureBox350
            // 
            this.pictureBox350.BackColor = System.Drawing.Color.Orange;
            this.pictureBox350.Location = new System.Drawing.Point(384, 176);
            this.pictureBox350.Name = "pictureBox350";
            this.pictureBox350.Size = new System.Drawing.Size(10, 10);
            this.pictureBox350.TabIndex = 342;
            this.pictureBox350.TabStop = false;
            this.pictureBox350.Tag = "coinScore";
            // 
            // pictureBox351
            // 
            this.pictureBox351.BackColor = System.Drawing.Color.Orange;
            this.pictureBox351.Location = new System.Drawing.Point(409, 176);
            this.pictureBox351.Name = "pictureBox351";
            this.pictureBox351.Size = new System.Drawing.Size(10, 10);
            this.pictureBox351.TabIndex = 341;
            this.pictureBox351.TabStop = false;
            this.pictureBox351.Tag = "coinScore";
            // 
            // pictureBox352
            // 
            this.pictureBox352.BackColor = System.Drawing.Color.Orange;
            this.pictureBox352.Location = new System.Drawing.Point(431, 176);
            this.pictureBox352.Name = "pictureBox352";
            this.pictureBox352.Size = new System.Drawing.Size(10, 10);
            this.pictureBox352.TabIndex = 340;
            this.pictureBox352.TabStop = false;
            this.pictureBox352.Tag = "coinScore";
            // 
            // pictureBox353
            // 
            this.pictureBox353.BackColor = System.Drawing.Color.Orange;
            this.pictureBox353.Location = new System.Drawing.Point(456, 176);
            this.pictureBox353.Name = "pictureBox353";
            this.pictureBox353.Size = new System.Drawing.Size(10, 10);
            this.pictureBox353.TabIndex = 339;
            this.pictureBox353.TabStop = false;
            this.pictureBox353.Tag = "coinScore";
            // 
            // pictureBox354
            // 
            this.pictureBox354.BackColor = System.Drawing.Color.Orange;
            this.pictureBox354.Location = new System.Drawing.Point(489, 148);
            this.pictureBox354.Name = "pictureBox354";
            this.pictureBox354.Size = new System.Drawing.Size(10, 10);
            this.pictureBox354.TabIndex = 338;
            this.pictureBox354.TabStop = false;
            this.pictureBox354.Tag = "coinScore";
            // 
            // pictureBox355
            // 
            this.pictureBox355.BackColor = System.Drawing.Color.Orange;
            this.pictureBox355.Location = new System.Drawing.Point(74, 239);
            this.pictureBox355.Name = "pictureBox355";
            this.pictureBox355.Size = new System.Drawing.Size(10, 10);
            this.pictureBox355.TabIndex = 373;
            this.pictureBox355.TabStop = false;
            this.pictureBox355.Tag = "coinScore";
            // 
            // pictureBox356
            // 
            this.pictureBox356.BackColor = System.Drawing.Color.Orange;
            this.pictureBox356.Location = new System.Drawing.Point(97, 239);
            this.pictureBox356.Name = "pictureBox356";
            this.pictureBox356.Size = new System.Drawing.Size(10, 10);
            this.pictureBox356.TabIndex = 372;
            this.pictureBox356.TabStop = false;
            this.pictureBox356.Tag = "coinScore";
            // 
            // pictureBox357
            // 
            this.pictureBox357.BackColor = System.Drawing.Color.Orange;
            this.pictureBox357.Location = new System.Drawing.Point(122, 239);
            this.pictureBox357.Name = "pictureBox357";
            this.pictureBox357.Size = new System.Drawing.Size(10, 10);
            this.pictureBox357.TabIndex = 371;
            this.pictureBox357.TabStop = false;
            this.pictureBox357.Tag = "coinScore";
            // 
            // pictureBox358
            // 
            this.pictureBox358.BackColor = System.Drawing.Color.Orange;
            this.pictureBox358.Location = new System.Drawing.Point(147, 239);
            this.pictureBox358.Name = "pictureBox358";
            this.pictureBox358.Size = new System.Drawing.Size(10, 10);
            this.pictureBox358.TabIndex = 370;
            this.pictureBox358.TabStop = false;
            this.pictureBox358.Tag = "coinScore";
            // 
            // pictureBox359
            // 
            this.pictureBox359.BackColor = System.Drawing.Color.Orange;
            this.pictureBox359.Location = new System.Drawing.Point(172, 239);
            this.pictureBox359.Name = "pictureBox359";
            this.pictureBox359.Size = new System.Drawing.Size(10, 10);
            this.pictureBox359.TabIndex = 369;
            this.pictureBox359.TabStop = false;
            this.pictureBox359.Tag = "coinScore";
            // 
            // pictureBox360
            // 
            this.pictureBox360.BackColor = System.Drawing.Color.Orange;
            this.pictureBox360.Location = new System.Drawing.Point(194, 239);
            this.pictureBox360.Name = "pictureBox360";
            this.pictureBox360.Size = new System.Drawing.Size(10, 10);
            this.pictureBox360.TabIndex = 368;
            this.pictureBox360.TabStop = false;
            this.pictureBox360.Tag = "coinScore";
            // 
            // pictureBox361
            // 
            this.pictureBox361.BackColor = System.Drawing.Color.Orange;
            this.pictureBox361.Location = new System.Drawing.Point(214, 239);
            this.pictureBox361.Name = "pictureBox361";
            this.pictureBox361.Size = new System.Drawing.Size(10, 10);
            this.pictureBox361.TabIndex = 367;
            this.pictureBox361.TabStop = false;
            this.pictureBox361.Tag = "coinScore";
            // 
            // pictureBox362
            // 
            this.pictureBox362.BackColor = System.Drawing.Color.Orange;
            this.pictureBox362.Location = new System.Drawing.Point(239, 239);
            this.pictureBox362.Name = "pictureBox362";
            this.pictureBox362.Size = new System.Drawing.Size(10, 10);
            this.pictureBox362.TabIndex = 366;
            this.pictureBox362.TabStop = false;
            this.pictureBox362.Tag = "coinScore";
            // 
            // pictureBox363
            // 
            this.pictureBox363.BackColor = System.Drawing.Color.Orange;
            this.pictureBox363.Location = new System.Drawing.Point(264, 239);
            this.pictureBox363.Name = "pictureBox363";
            this.pictureBox363.Size = new System.Drawing.Size(10, 10);
            this.pictureBox363.TabIndex = 365;
            this.pictureBox363.TabStop = false;
            this.pictureBox363.Tag = "coinScore";
            // 
            // pictureBox364
            // 
            this.pictureBox364.BackColor = System.Drawing.Color.Orange;
            this.pictureBox364.Location = new System.Drawing.Point(289, 239);
            this.pictureBox364.Name = "pictureBox364";
            this.pictureBox364.Size = new System.Drawing.Size(10, 10);
            this.pictureBox364.TabIndex = 364;
            this.pictureBox364.TabStop = false;
            this.pictureBox364.Tag = "coinScore";
            // 
            // pictureBox365
            // 
            this.pictureBox365.BackColor = System.Drawing.Color.Orange;
            this.pictureBox365.Location = new System.Drawing.Point(311, 239);
            this.pictureBox365.Name = "pictureBox365";
            this.pictureBox365.Size = new System.Drawing.Size(10, 10);
            this.pictureBox365.TabIndex = 363;
            this.pictureBox365.TabStop = false;
            this.pictureBox365.Tag = "coinScore";
            // 
            // pictureBox366
            // 
            this.pictureBox366.BackColor = System.Drawing.Color.Orange;
            this.pictureBox366.Location = new System.Drawing.Point(334, 239);
            this.pictureBox366.Name = "pictureBox366";
            this.pictureBox366.Size = new System.Drawing.Size(10, 10);
            this.pictureBox366.TabIndex = 362;
            this.pictureBox366.TabStop = false;
            this.pictureBox366.Tag = "coinScore";
            // 
            // pictureBox367
            // 
            this.pictureBox367.BackColor = System.Drawing.Color.Orange;
            this.pictureBox367.Location = new System.Drawing.Point(359, 239);
            this.pictureBox367.Name = "pictureBox367";
            this.pictureBox367.Size = new System.Drawing.Size(10, 10);
            this.pictureBox367.TabIndex = 361;
            this.pictureBox367.TabStop = false;
            this.pictureBox367.Tag = "coinScore";
            // 
            // pictureBox368
            // 
            this.pictureBox368.BackColor = System.Drawing.Color.Orange;
            this.pictureBox368.Location = new System.Drawing.Point(384, 239);
            this.pictureBox368.Name = "pictureBox368";
            this.pictureBox368.Size = new System.Drawing.Size(10, 10);
            this.pictureBox368.TabIndex = 360;
            this.pictureBox368.TabStop = false;
            this.pictureBox368.Tag = "coinScore";
            // 
            // pictureBox369
            // 
            this.pictureBox369.BackColor = System.Drawing.Color.Orange;
            this.pictureBox369.Location = new System.Drawing.Point(409, 239);
            this.pictureBox369.Name = "pictureBox369";
            this.pictureBox369.Size = new System.Drawing.Size(10, 10);
            this.pictureBox369.TabIndex = 359;
            this.pictureBox369.TabStop = false;
            this.pictureBox369.Tag = "coinScore";
            // 
            // pictureBox370
            // 
            this.pictureBox370.BackColor = System.Drawing.Color.Orange;
            this.pictureBox370.Location = new System.Drawing.Point(431, 239);
            this.pictureBox370.Name = "pictureBox370";
            this.pictureBox370.Size = new System.Drawing.Size(10, 10);
            this.pictureBox370.TabIndex = 358;
            this.pictureBox370.TabStop = false;
            this.pictureBox370.Tag = "coinScore";
            // 
            // pictureBox371
            // 
            this.pictureBox371.BackColor = System.Drawing.Color.Orange;
            this.pictureBox371.Location = new System.Drawing.Point(456, 239);
            this.pictureBox371.Name = "pictureBox371";
            this.pictureBox371.Size = new System.Drawing.Size(10, 10);
            this.pictureBox371.TabIndex = 357;
            this.pictureBox371.TabStop = false;
            this.pictureBox371.Tag = "coinScore";
            // 
            // pictureBox372
            // 
            this.pictureBox372.BackColor = System.Drawing.Color.Orange;
            this.pictureBox372.Location = new System.Drawing.Point(489, 239);
            this.pictureBox372.Name = "pictureBox372";
            this.pictureBox372.Size = new System.Drawing.Size(10, 10);
            this.pictureBox372.TabIndex = 356;
            this.pictureBox372.TabStop = false;
            this.pictureBox372.Tag = "coinScore";
            // 
            // pictureBox373
            // 
            this.pictureBox373.BackColor = System.Drawing.Color.Orange;
            this.pictureBox373.Location = new System.Drawing.Point(74, 307);
            this.pictureBox373.Name = "pictureBox373";
            this.pictureBox373.Size = new System.Drawing.Size(10, 10);
            this.pictureBox373.TabIndex = 391;
            this.pictureBox373.TabStop = false;
            this.pictureBox373.Tag = "coinScore";
            // 
            // pictureBox374
            // 
            this.pictureBox374.BackColor = System.Drawing.Color.Orange;
            this.pictureBox374.Location = new System.Drawing.Point(97, 307);
            this.pictureBox374.Name = "pictureBox374";
            this.pictureBox374.Size = new System.Drawing.Size(10, 10);
            this.pictureBox374.TabIndex = 390;
            this.pictureBox374.TabStop = false;
            this.pictureBox374.Tag = "coinScore";
            // 
            // pictureBox375
            // 
            this.pictureBox375.BackColor = System.Drawing.Color.Orange;
            this.pictureBox375.Location = new System.Drawing.Point(122, 307);
            this.pictureBox375.Name = "pictureBox375";
            this.pictureBox375.Size = new System.Drawing.Size(10, 10);
            this.pictureBox375.TabIndex = 389;
            this.pictureBox375.TabStop = false;
            this.pictureBox375.Tag = "coinScore";
            // 
            // pictureBox376
            // 
            this.pictureBox376.BackColor = System.Drawing.Color.Orange;
            this.pictureBox376.Location = new System.Drawing.Point(147, 307);
            this.pictureBox376.Name = "pictureBox376";
            this.pictureBox376.Size = new System.Drawing.Size(10, 10);
            this.pictureBox376.TabIndex = 388;
            this.pictureBox376.TabStop = false;
            this.pictureBox376.Tag = "coinScore";
            // 
            // pictureBox377
            // 
            this.pictureBox377.BackColor = System.Drawing.Color.Orange;
            this.pictureBox377.Location = new System.Drawing.Point(172, 307);
            this.pictureBox377.Name = "pictureBox377";
            this.pictureBox377.Size = new System.Drawing.Size(10, 10);
            this.pictureBox377.TabIndex = 387;
            this.pictureBox377.TabStop = false;
            this.pictureBox377.Tag = "coinScore";
            // 
            // pictureBox378
            // 
            this.pictureBox378.BackColor = System.Drawing.Color.Orange;
            this.pictureBox378.Location = new System.Drawing.Point(194, 307);
            this.pictureBox378.Name = "pictureBox378";
            this.pictureBox378.Size = new System.Drawing.Size(10, 10);
            this.pictureBox378.TabIndex = 386;
            this.pictureBox378.TabStop = false;
            this.pictureBox378.Tag = "coinScore";
            // 
            // pictureBox379
            // 
            this.pictureBox379.BackColor = System.Drawing.Color.Orange;
            this.pictureBox379.Location = new System.Drawing.Point(214, 307);
            this.pictureBox379.Name = "pictureBox379";
            this.pictureBox379.Size = new System.Drawing.Size(10, 10);
            this.pictureBox379.TabIndex = 385;
            this.pictureBox379.TabStop = false;
            this.pictureBox379.Tag = "coinScore";
            // 
            // pictureBox380
            // 
            this.pictureBox380.BackColor = System.Drawing.Color.Orange;
            this.pictureBox380.Location = new System.Drawing.Point(239, 307);
            this.pictureBox380.Name = "pictureBox380";
            this.pictureBox380.Size = new System.Drawing.Size(10, 10);
            this.pictureBox380.TabIndex = 384;
            this.pictureBox380.TabStop = false;
            this.pictureBox380.Tag = "coinScore";
            // 
            // pictureBox381
            // 
            this.pictureBox381.BackColor = System.Drawing.Color.Orange;
            this.pictureBox381.Location = new System.Drawing.Point(264, 307);
            this.pictureBox381.Name = "pictureBox381";
            this.pictureBox381.Size = new System.Drawing.Size(10, 10);
            this.pictureBox381.TabIndex = 383;
            this.pictureBox381.TabStop = false;
            this.pictureBox381.Tag = "coinScore";
            // 
            // pictureBox382
            // 
            this.pictureBox382.BackColor = System.Drawing.Color.Orange;
            this.pictureBox382.Location = new System.Drawing.Point(289, 307);
            this.pictureBox382.Name = "pictureBox382";
            this.pictureBox382.Size = new System.Drawing.Size(10, 10);
            this.pictureBox382.TabIndex = 382;
            this.pictureBox382.TabStop = false;
            this.pictureBox382.Tag = "coinScore";
            // 
            // pictureBox383
            // 
            this.pictureBox383.BackColor = System.Drawing.Color.Orange;
            this.pictureBox383.Location = new System.Drawing.Point(311, 307);
            this.pictureBox383.Name = "pictureBox383";
            this.pictureBox383.Size = new System.Drawing.Size(10, 10);
            this.pictureBox383.TabIndex = 381;
            this.pictureBox383.TabStop = false;
            this.pictureBox383.Tag = "coinScore";
            // 
            // pictureBox384
            // 
            this.pictureBox384.BackColor = System.Drawing.Color.Orange;
            this.pictureBox384.Location = new System.Drawing.Point(334, 307);
            this.pictureBox384.Name = "pictureBox384";
            this.pictureBox384.Size = new System.Drawing.Size(10, 10);
            this.pictureBox384.TabIndex = 380;
            this.pictureBox384.TabStop = false;
            this.pictureBox384.Tag = "coinScore";
            // 
            // pictureBox385
            // 
            this.pictureBox385.BackColor = System.Drawing.Color.Orange;
            this.pictureBox385.Location = new System.Drawing.Point(359, 307);
            this.pictureBox385.Name = "pictureBox385";
            this.pictureBox385.Size = new System.Drawing.Size(10, 10);
            this.pictureBox385.TabIndex = 379;
            this.pictureBox385.TabStop = false;
            this.pictureBox385.Tag = "coinScore";
            // 
            // pictureBox386
            // 
            this.pictureBox386.BackColor = System.Drawing.Color.Orange;
            this.pictureBox386.Location = new System.Drawing.Point(384, 307);
            this.pictureBox386.Name = "pictureBox386";
            this.pictureBox386.Size = new System.Drawing.Size(10, 10);
            this.pictureBox386.TabIndex = 378;
            this.pictureBox386.TabStop = false;
            this.pictureBox386.Tag = "coinScore";
            // 
            // pictureBox387
            // 
            this.pictureBox387.BackColor = System.Drawing.Color.Orange;
            this.pictureBox387.Location = new System.Drawing.Point(409, 307);
            this.pictureBox387.Name = "pictureBox387";
            this.pictureBox387.Size = new System.Drawing.Size(10, 10);
            this.pictureBox387.TabIndex = 377;
            this.pictureBox387.TabStop = false;
            this.pictureBox387.Tag = "coinScore";
            // 
            // pictureBox388
            // 
            this.pictureBox388.BackColor = System.Drawing.Color.Orange;
            this.pictureBox388.Location = new System.Drawing.Point(431, 307);
            this.pictureBox388.Name = "pictureBox388";
            this.pictureBox388.Size = new System.Drawing.Size(10, 10);
            this.pictureBox388.TabIndex = 376;
            this.pictureBox388.TabStop = false;
            this.pictureBox388.Tag = "coinScore";
            // 
            // pictureBox389
            // 
            this.pictureBox389.BackColor = System.Drawing.Color.Orange;
            this.pictureBox389.Location = new System.Drawing.Point(456, 307);
            this.pictureBox389.Name = "pictureBox389";
            this.pictureBox389.Size = new System.Drawing.Size(10, 10);
            this.pictureBox389.TabIndex = 375;
            this.pictureBox389.TabStop = false;
            this.pictureBox389.Tag = "coinScore";
            // 
            // pictureBox390
            // 
            this.pictureBox390.BackColor = System.Drawing.Color.Orange;
            this.pictureBox390.Location = new System.Drawing.Point(489, 307);
            this.pictureBox390.Name = "pictureBox390";
            this.pictureBox390.Size = new System.Drawing.Size(10, 10);
            this.pictureBox390.TabIndex = 374;
            this.pictureBox390.TabStop = false;
            this.pictureBox390.Tag = "coinScore";
            // 
            // pictureBox391
            // 
            this.pictureBox391.BackColor = System.Drawing.Color.Orange;
            this.pictureBox391.Location = new System.Drawing.Point(677, 358);
            this.pictureBox391.Name = "pictureBox391";
            this.pictureBox391.Size = new System.Drawing.Size(10, 10);
            this.pictureBox391.TabIndex = 398;
            this.pictureBox391.TabStop = false;
            this.pictureBox391.Tag = "coinScore";
            // 
            // pictureBox392
            // 
            this.pictureBox392.BackColor = System.Drawing.Color.Orange;
            this.pictureBox392.Location = new System.Drawing.Point(700, 358);
            this.pictureBox392.Name = "pictureBox392";
            this.pictureBox392.Size = new System.Drawing.Size(10, 10);
            this.pictureBox392.TabIndex = 397;
            this.pictureBox392.TabStop = false;
            this.pictureBox392.Tag = "coinScore";
            // 
            // pictureBox393
            // 
            this.pictureBox393.BackColor = System.Drawing.Color.Orange;
            this.pictureBox393.Location = new System.Drawing.Point(725, 358);
            this.pictureBox393.Name = "pictureBox393";
            this.pictureBox393.Size = new System.Drawing.Size(10, 10);
            this.pictureBox393.TabIndex = 396;
            this.pictureBox393.TabStop = false;
            this.pictureBox393.Tag = "coinScore";
            // 
            // pictureBox394
            // 
            this.pictureBox394.BackColor = System.Drawing.Color.Orange;
            this.pictureBox394.Location = new System.Drawing.Point(750, 358);
            this.pictureBox394.Name = "pictureBox394";
            this.pictureBox394.Size = new System.Drawing.Size(10, 10);
            this.pictureBox394.TabIndex = 395;
            this.pictureBox394.TabStop = false;
            this.pictureBox394.Tag = "coinScore";
            // 
            // pictureBox395
            // 
            this.pictureBox395.BackColor = System.Drawing.Color.Orange;
            this.pictureBox395.Location = new System.Drawing.Point(775, 358);
            this.pictureBox395.Name = "pictureBox395";
            this.pictureBox395.Size = new System.Drawing.Size(10, 10);
            this.pictureBox395.TabIndex = 394;
            this.pictureBox395.TabStop = false;
            this.pictureBox395.Tag = "coinScore";
            // 
            // pictureBox396
            // 
            this.pictureBox396.BackColor = System.Drawing.Color.Orange;
            this.pictureBox396.Location = new System.Drawing.Point(797, 358);
            this.pictureBox396.Name = "pictureBox396";
            this.pictureBox396.Size = new System.Drawing.Size(10, 10);
            this.pictureBox396.TabIndex = 393;
            this.pictureBox396.TabStop = false;
            this.pictureBox396.Tag = "coinScore";
            // 
            // pictureBox397
            // 
            this.pictureBox397.BackColor = System.Drawing.Color.Orange;
            this.pictureBox397.Location = new System.Drawing.Point(822, 358);
            this.pictureBox397.Name = "pictureBox397";
            this.pictureBox397.Size = new System.Drawing.Size(10, 10);
            this.pictureBox397.TabIndex = 392;
            this.pictureBox397.TabStop = false;
            this.pictureBox397.Tag = "coinScore";
            // 
            // pictureBox398
            // 
            this.pictureBox398.BackColor = System.Drawing.Color.Orange;
            this.pictureBox398.Location = new System.Drawing.Point(455, 489);
            this.pictureBox398.Name = "pictureBox398";
            this.pictureBox398.Size = new System.Drawing.Size(10, 10);
            this.pictureBox398.TabIndex = 412;
            this.pictureBox398.TabStop = false;
            this.pictureBox398.Tag = "coinScore";
            // 
            // pictureBox399
            // 
            this.pictureBox399.BackColor = System.Drawing.Color.Orange;
            this.pictureBox399.Location = new System.Drawing.Point(480, 489);
            this.pictureBox399.Name = "pictureBox399";
            this.pictureBox399.Size = new System.Drawing.Size(10, 10);
            this.pictureBox399.TabIndex = 411;
            this.pictureBox399.TabStop = false;
            this.pictureBox399.Tag = "coinScore";
            // 
            // pictureBox400
            // 
            this.pictureBox400.BackColor = System.Drawing.Color.Orange;
            this.pictureBox400.Location = new System.Drawing.Point(502, 489);
            this.pictureBox400.Name = "pictureBox400";
            this.pictureBox400.Size = new System.Drawing.Size(10, 10);
            this.pictureBox400.TabIndex = 410;
            this.pictureBox400.TabStop = false;
            this.pictureBox400.Tag = "coinScore";
            // 
            // pictureBox401
            // 
            this.pictureBox401.BackColor = System.Drawing.Color.Orange;
            this.pictureBox401.Location = new System.Drawing.Point(522, 489);
            this.pictureBox401.Name = "pictureBox401";
            this.pictureBox401.Size = new System.Drawing.Size(10, 10);
            this.pictureBox401.TabIndex = 409;
            this.pictureBox401.TabStop = false;
            this.pictureBox401.Tag = "coinScore";
            // 
            // pictureBox402
            // 
            this.pictureBox402.BackColor = System.Drawing.Color.Orange;
            this.pictureBox402.Location = new System.Drawing.Point(547, 489);
            this.pictureBox402.Name = "pictureBox402";
            this.pictureBox402.Size = new System.Drawing.Size(10, 10);
            this.pictureBox402.TabIndex = 408;
            this.pictureBox402.TabStop = false;
            this.pictureBox402.Tag = "coinScore";
            // 
            // pictureBox403
            // 
            this.pictureBox403.BackColor = System.Drawing.Color.Orange;
            this.pictureBox403.Location = new System.Drawing.Point(572, 489);
            this.pictureBox403.Name = "pictureBox403";
            this.pictureBox403.Size = new System.Drawing.Size(10, 10);
            this.pictureBox403.TabIndex = 407;
            this.pictureBox403.TabStop = false;
            this.pictureBox403.Tag = "coinScore";
            // 
            // pictureBox404
            // 
            this.pictureBox404.BackColor = System.Drawing.Color.Orange;
            this.pictureBox404.Location = new System.Drawing.Point(597, 489);
            this.pictureBox404.Name = "pictureBox404";
            this.pictureBox404.Size = new System.Drawing.Size(10, 10);
            this.pictureBox404.TabIndex = 406;
            this.pictureBox404.TabStop = false;
            this.pictureBox404.Tag = "coinScore";
            // 
            // pictureBox405
            // 
            this.pictureBox405.BackColor = System.Drawing.Color.Orange;
            this.pictureBox405.Location = new System.Drawing.Point(619, 489);
            this.pictureBox405.Name = "pictureBox405";
            this.pictureBox405.Size = new System.Drawing.Size(10, 10);
            this.pictureBox405.TabIndex = 405;
            this.pictureBox405.TabStop = false;
            this.pictureBox405.Tag = "coinScore";
            // 
            // pictureBox406
            // 
            this.pictureBox406.BackColor = System.Drawing.Color.Orange;
            this.pictureBox406.Location = new System.Drawing.Point(642, 489);
            this.pictureBox406.Name = "pictureBox406";
            this.pictureBox406.Size = new System.Drawing.Size(10, 10);
            this.pictureBox406.TabIndex = 404;
            this.pictureBox406.TabStop = false;
            this.pictureBox406.Tag = "coinScore";
            // 
            // pictureBox407
            // 
            this.pictureBox407.BackColor = System.Drawing.Color.Orange;
            this.pictureBox407.Location = new System.Drawing.Point(667, 489);
            this.pictureBox407.Name = "pictureBox407";
            this.pictureBox407.Size = new System.Drawing.Size(10, 10);
            this.pictureBox407.TabIndex = 403;
            this.pictureBox407.TabStop = false;
            this.pictureBox407.Tag = "coinScore";
            // 
            // pictureBox408
            // 
            this.pictureBox408.BackColor = System.Drawing.Color.Orange;
            this.pictureBox408.Location = new System.Drawing.Point(692, 489);
            this.pictureBox408.Name = "pictureBox408";
            this.pictureBox408.Size = new System.Drawing.Size(10, 10);
            this.pictureBox408.TabIndex = 402;
            this.pictureBox408.TabStop = false;
            this.pictureBox408.Tag = "coinScore";
            // 
            // pictureBox409
            // 
            this.pictureBox409.BackColor = System.Drawing.Color.Orange;
            this.pictureBox409.Location = new System.Drawing.Point(717, 489);
            this.pictureBox409.Name = "pictureBox409";
            this.pictureBox409.Size = new System.Drawing.Size(10, 10);
            this.pictureBox409.TabIndex = 401;
            this.pictureBox409.TabStop = false;
            this.pictureBox409.Tag = "coinScore";
            // 
            // pictureBox410
            // 
            this.pictureBox410.BackColor = System.Drawing.Color.Orange;
            this.pictureBox410.Location = new System.Drawing.Point(739, 489);
            this.pictureBox410.Name = "pictureBox410";
            this.pictureBox410.Size = new System.Drawing.Size(10, 10);
            this.pictureBox410.TabIndex = 400;
            this.pictureBox410.TabStop = false;
            this.pictureBox410.Tag = "coinScore";
            // 
            // pictureBox411
            // 
            this.pictureBox411.BackColor = System.Drawing.Color.Orange;
            this.pictureBox411.Location = new System.Drawing.Point(764, 489);
            this.pictureBox411.Name = "pictureBox411";
            this.pictureBox411.Size = new System.Drawing.Size(10, 10);
            this.pictureBox411.TabIndex = 399;
            this.pictureBox411.TabStop = false;
            this.pictureBox411.Tag = "coinScore";
            // 
            // pictureBox412
            // 
            this.pictureBox412.BackColor = System.Drawing.Color.Orange;
            this.pictureBox412.Location = new System.Drawing.Point(800, 489);
            this.pictureBox412.Name = "pictureBox412";
            this.pictureBox412.Size = new System.Drawing.Size(10, 10);
            this.pictureBox412.TabIndex = 415;
            this.pictureBox412.TabStop = false;
            this.pictureBox412.Tag = "coinScore";
            // 
            // pictureBox413
            // 
            this.pictureBox413.BackColor = System.Drawing.Color.Orange;
            this.pictureBox413.Location = new System.Drawing.Point(822, 489);
            this.pictureBox413.Name = "pictureBox413";
            this.pictureBox413.Size = new System.Drawing.Size(10, 10);
            this.pictureBox413.TabIndex = 414;
            this.pictureBox413.TabStop = false;
            this.pictureBox413.Tag = "coinScore";
            // 
            // pictureBox414
            // 
            this.pictureBox414.BackColor = System.Drawing.Color.Orange;
            this.pictureBox414.Location = new System.Drawing.Point(847, 489);
            this.pictureBox414.Name = "pictureBox414";
            this.pictureBox414.Size = new System.Drawing.Size(10, 10);
            this.pictureBox414.TabIndex = 413;
            this.pictureBox414.TabStop = false;
            this.pictureBox414.Tag = "coinScore";
            // 
            // pictureBox415
            // 
            this.pictureBox415.BackColor = System.Drawing.Color.Orange;
            this.pictureBox415.Location = new System.Drawing.Point(511, 108);
            this.pictureBox415.Name = "pictureBox415";
            this.pictureBox415.Size = new System.Drawing.Size(10, 10);
            this.pictureBox415.TabIndex = 424;
            this.pictureBox415.TabStop = false;
            this.pictureBox415.Tag = "coinScore";
            // 
            // pictureBox416
            // 
            this.pictureBox416.BackColor = System.Drawing.Color.Orange;
            this.pictureBox416.Location = new System.Drawing.Point(534, 108);
            this.pictureBox416.Name = "pictureBox416";
            this.pictureBox416.Size = new System.Drawing.Size(10, 10);
            this.pictureBox416.TabIndex = 423;
            this.pictureBox416.TabStop = false;
            this.pictureBox416.Tag = "coinScore";
            // 
            // pictureBox417
            // 
            this.pictureBox417.BackColor = System.Drawing.Color.Orange;
            this.pictureBox417.Location = new System.Drawing.Point(559, 108);
            this.pictureBox417.Name = "pictureBox417";
            this.pictureBox417.Size = new System.Drawing.Size(10, 10);
            this.pictureBox417.TabIndex = 422;
            this.pictureBox417.TabStop = false;
            this.pictureBox417.Tag = "coinScore";
            // 
            // pictureBox418
            // 
            this.pictureBox418.BackColor = System.Drawing.Color.Orange;
            this.pictureBox418.Location = new System.Drawing.Point(584, 108);
            this.pictureBox418.Name = "pictureBox418";
            this.pictureBox418.Size = new System.Drawing.Size(10, 10);
            this.pictureBox418.TabIndex = 421;
            this.pictureBox418.TabStop = false;
            this.pictureBox418.Tag = "coinScore";
            // 
            // pictureBox419
            // 
            this.pictureBox419.BackColor = System.Drawing.Color.Orange;
            this.pictureBox419.Location = new System.Drawing.Point(609, 108);
            this.pictureBox419.Name = "pictureBox419";
            this.pictureBox419.Size = new System.Drawing.Size(10, 10);
            this.pictureBox419.TabIndex = 420;
            this.pictureBox419.TabStop = false;
            this.pictureBox419.Tag = "coinScore";
            // 
            // pictureBox420
            // 
            this.pictureBox420.BackColor = System.Drawing.Color.Orange;
            this.pictureBox420.Location = new System.Drawing.Point(631, 108);
            this.pictureBox420.Name = "pictureBox420";
            this.pictureBox420.Size = new System.Drawing.Size(10, 10);
            this.pictureBox420.TabIndex = 419;
            this.pictureBox420.TabStop = false;
            this.pictureBox420.Tag = "coinScore";
            // 
            // pictureBox421
            // 
            this.pictureBox421.BackColor = System.Drawing.Color.Orange;
            this.pictureBox421.Location = new System.Drawing.Point(651, 108);
            this.pictureBox421.Name = "pictureBox421";
            this.pictureBox421.Size = new System.Drawing.Size(10, 10);
            this.pictureBox421.TabIndex = 418;
            this.pictureBox421.TabStop = false;
            this.pictureBox421.Tag = "coinScore";
            // 
            // pictureBox422
            // 
            this.pictureBox422.BackColor = System.Drawing.Color.Orange;
            this.pictureBox422.Location = new System.Drawing.Point(676, 108);
            this.pictureBox422.Name = "pictureBox422";
            this.pictureBox422.Size = new System.Drawing.Size(10, 10);
            this.pictureBox422.TabIndex = 417;
            this.pictureBox422.TabStop = false;
            this.pictureBox422.Tag = "coinScore";
            // 
            // pictureBox423
            // 
            this.pictureBox423.BackColor = System.Drawing.Color.Orange;
            this.pictureBox423.Location = new System.Drawing.Point(701, 108);
            this.pictureBox423.Name = "pictureBox423";
            this.pictureBox423.Size = new System.Drawing.Size(10, 10);
            this.pictureBox423.TabIndex = 416;
            this.pictureBox423.TabStop = false;
            this.pictureBox423.Tag = "coinScore";
            // 
            // pictureBox424
            // 
            this.pictureBox424.BackColor = System.Drawing.Color.Orange;
            this.pictureBox424.Location = new System.Drawing.Point(741, 108);
            this.pictureBox424.Name = "pictureBox424";
            this.pictureBox424.Size = new System.Drawing.Size(10, 10);
            this.pictureBox424.TabIndex = 427;
            this.pictureBox424.TabStop = false;
            this.pictureBox424.Tag = "coinScore";
            // 
            // pictureBox425
            // 
            this.pictureBox425.BackColor = System.Drawing.Color.Orange;
            this.pictureBox425.Location = new System.Drawing.Point(764, 108);
            this.pictureBox425.Name = "pictureBox425";
            this.pictureBox425.Size = new System.Drawing.Size(10, 10);
            this.pictureBox425.TabIndex = 426;
            this.pictureBox425.TabStop = false;
            this.pictureBox425.Tag = "coinScore";
            // 
            // pictureBox426
            // 
            this.pictureBox426.BackColor = System.Drawing.Color.Orange;
            this.pictureBox426.Location = new System.Drawing.Point(789, 108);
            this.pictureBox426.Name = "pictureBox426";
            this.pictureBox426.Size = new System.Drawing.Size(10, 10);
            this.pictureBox426.TabIndex = 425;
            this.pictureBox426.TabStop = false;
            this.pictureBox426.Tag = "coinScore";
            // 
            // pictureBox428
            // 
            this.pictureBox428.BackColor = System.Drawing.Color.Orange;
            this.pictureBox428.Location = new System.Drawing.Point(37, 60);
            this.pictureBox428.Name = "pictureBox428";
            this.pictureBox428.Size = new System.Drawing.Size(10, 10);
            this.pictureBox428.TabIndex = 440;
            this.pictureBox428.TabStop = false;
            this.pictureBox428.Tag = "coinScore";
            // 
            // pictureBox429
            // 
            this.pictureBox429.BackColor = System.Drawing.Color.Orange;
            this.pictureBox429.Location = new System.Drawing.Point(37, 76);
            this.pictureBox429.Name = "pictureBox429";
            this.pictureBox429.Size = new System.Drawing.Size(10, 10);
            this.pictureBox429.TabIndex = 439;
            this.pictureBox429.TabStop = false;
            this.pictureBox429.Tag = "coinScore";
            // 
            // pictureBox430
            // 
            this.pictureBox430.BackColor = System.Drawing.Color.Orange;
            this.pictureBox430.Location = new System.Drawing.Point(37, 92);
            this.pictureBox430.Name = "pictureBox430";
            this.pictureBox430.Size = new System.Drawing.Size(10, 10);
            this.pictureBox430.TabIndex = 438;
            this.pictureBox430.TabStop = false;
            this.pictureBox430.Tag = "coinScore";
            // 
            // pictureBox431
            // 
            this.pictureBox431.BackColor = System.Drawing.Color.Orange;
            this.pictureBox431.Location = new System.Drawing.Point(37, 108);
            this.pictureBox431.Name = "pictureBox431";
            this.pictureBox431.Size = new System.Drawing.Size(10, 10);
            this.pictureBox431.TabIndex = 437;
            this.pictureBox431.TabStop = false;
            this.pictureBox431.Tag = "coinScore";
            // 
            // pictureBox432
            // 
            this.pictureBox432.BackColor = System.Drawing.Color.Orange;
            this.pictureBox432.Location = new System.Drawing.Point(37, 124);
            this.pictureBox432.Name = "pictureBox432";
            this.pictureBox432.Size = new System.Drawing.Size(10, 10);
            this.pictureBox432.TabIndex = 436;
            this.pictureBox432.TabStop = false;
            this.pictureBox432.Tag = "coinScore";
            // 
            // pictureBox433
            // 
            this.pictureBox433.BackColor = System.Drawing.Color.Orange;
            this.pictureBox433.Location = new System.Drawing.Point(37, 140);
            this.pictureBox433.Name = "pictureBox433";
            this.pictureBox433.Size = new System.Drawing.Size(10, 10);
            this.pictureBox433.TabIndex = 435;
            this.pictureBox433.TabStop = false;
            this.pictureBox433.Tag = "coinScore";
            // 
            // pictureBox434
            // 
            this.pictureBox434.BackColor = System.Drawing.Color.Orange;
            this.pictureBox434.Location = new System.Drawing.Point(37, 156);
            this.pictureBox434.Name = "pictureBox434";
            this.pictureBox434.Size = new System.Drawing.Size(10, 10);
            this.pictureBox434.TabIndex = 434;
            this.pictureBox434.TabStop = false;
            this.pictureBox434.Tag = "coinScore";
            // 
            // pictureBox435
            // 
            this.pictureBox435.BackColor = System.Drawing.Color.Orange;
            this.pictureBox435.Location = new System.Drawing.Point(37, 172);
            this.pictureBox435.Name = "pictureBox435";
            this.pictureBox435.Size = new System.Drawing.Size(10, 10);
            this.pictureBox435.TabIndex = 433;
            this.pictureBox435.TabStop = false;
            this.pictureBox435.Tag = "coinScore";
            // 
            // pictureBox436
            // 
            this.pictureBox436.BackColor = System.Drawing.Color.Orange;
            this.pictureBox436.Location = new System.Drawing.Point(37, 188);
            this.pictureBox436.Name = "pictureBox436";
            this.pictureBox436.Size = new System.Drawing.Size(10, 10);
            this.pictureBox436.TabIndex = 432;
            this.pictureBox436.TabStop = false;
            this.pictureBox436.Tag = "coinScore";
            // 
            // pictureBox437
            // 
            this.pictureBox437.BackColor = System.Drawing.Color.Orange;
            this.pictureBox437.Location = new System.Drawing.Point(37, 207);
            this.pictureBox437.Name = "pictureBox437";
            this.pictureBox437.Size = new System.Drawing.Size(10, 10);
            this.pictureBox437.TabIndex = 431;
            this.pictureBox437.TabStop = false;
            this.pictureBox437.Tag = "coinScore";
            // 
            // pictureBox438
            // 
            this.pictureBox438.BackColor = System.Drawing.Color.Orange;
            this.pictureBox438.Location = new System.Drawing.Point(37, 223);
            this.pictureBox438.Name = "pictureBox438";
            this.pictureBox438.Size = new System.Drawing.Size(10, 10);
            this.pictureBox438.TabIndex = 430;
            this.pictureBox438.TabStop = false;
            this.pictureBox438.Tag = "coinScore";
            // 
            // pictureBox439
            // 
            this.pictureBox439.BackColor = System.Drawing.Color.Orange;
            this.pictureBox439.Location = new System.Drawing.Point(37, 239);
            this.pictureBox439.Name = "pictureBox439";
            this.pictureBox439.Size = new System.Drawing.Size(10, 10);
            this.pictureBox439.TabIndex = 429;
            this.pictureBox439.TabStop = false;
            this.pictureBox439.Tag = "coinScore";
            // 
            // pictureBox440
            // 
            this.pictureBox440.BackColor = System.Drawing.Color.Orange;
            this.pictureBox440.Location = new System.Drawing.Point(37, 255);
            this.pictureBox440.Name = "pictureBox440";
            this.pictureBox440.Size = new System.Drawing.Size(10, 10);
            this.pictureBox440.TabIndex = 428;
            this.pictureBox440.TabStop = false;
            this.pictureBox440.Tag = "coinScore";
            // 
            // pictureBox427
            // 
            this.pictureBox427.BackColor = System.Drawing.Color.Orange;
            this.pictureBox427.Location = new System.Drawing.Point(897, 64);
            this.pictureBox427.Name = "pictureBox427";
            this.pictureBox427.Size = new System.Drawing.Size(10, 10);
            this.pictureBox427.TabIndex = 441;
            this.pictureBox427.TabStop = false;
            this.pictureBox427.Tag = "coinScore";
            // 
            // pictureBox441
            // 
            this.pictureBox441.BackColor = System.Drawing.Color.Orange;
            this.pictureBox441.Location = new System.Drawing.Point(489, 128);
            this.pictureBox441.Name = "pictureBox441";
            this.pictureBox441.Size = new System.Drawing.Size(10, 10);
            this.pictureBox441.TabIndex = 442;
            this.pictureBox441.TabStop = false;
            this.pictureBox441.Tag = "coinScore";
            // 
            // pictureBox442
            // 
            this.pictureBox442.BackColor = System.Drawing.Color.Orange;
            this.pictureBox442.Location = new System.Drawing.Point(431, 76);
            this.pictureBox442.Name = "pictureBox442";
            this.pictureBox442.Size = new System.Drawing.Size(10, 10);
            this.pictureBox442.TabIndex = 443;
            this.pictureBox442.TabStop = false;
            this.pictureBox442.Tag = "coinScore";
            // 
            // pictureBox443
            // 
            this.pictureBox443.BackColor = System.Drawing.Color.Orange;
            this.pictureBox443.Location = new System.Drawing.Point(725, 108);
            this.pictureBox443.Name = "pictureBox443";
            this.pictureBox443.Size = new System.Drawing.Size(10, 10);
            this.pictureBox443.TabIndex = 444;
            this.pictureBox443.TabStop = false;
            this.pictureBox443.Tag = "coinScore";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.IndianRed;
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackColor = System.Drawing.Color.Orange;
            this.pictureBox47.Location = new System.Drawing.Point(489, 331);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(10, 10);
            this.pictureBox47.TabIndex = 445;
            this.pictureBox47.TabStop = false;
            this.pictureBox47.Tag = "coinScore";
            // 
            // pictureBox48
            // 
            this.pictureBox48.BackColor = System.Drawing.Color.Orange;
            this.pictureBox48.Location = new System.Drawing.Point(489, 278);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(10, 10);
            this.pictureBox48.TabIndex = 446;
            this.pictureBox48.TabStop = false;
            this.pictureBox48.Tag = "coinScore";
            // 
            // pictureBox444
            // 
            this.pictureBox444.BackColor = System.Drawing.Color.Orange;
            this.pictureBox444.Location = new System.Drawing.Point(489, 259);
            this.pictureBox444.Name = "pictureBox444";
            this.pictureBox444.Size = new System.Drawing.Size(10, 10);
            this.pictureBox444.TabIndex = 447;
            this.pictureBox444.TabStop = false;
            this.pictureBox444.Tag = "coinScore";
            this.pictureBox444.Click += new System.EventHandler(this.pictureBox444_Click);
            // 
            // pictureBox445
            // 
            this.pictureBox445.BackColor = System.Drawing.Color.Orange;
            this.pictureBox445.Location = new System.Drawing.Point(489, 192);
            this.pictureBox445.Name = "pictureBox445";
            this.pictureBox445.Size = new System.Drawing.Size(10, 10);
            this.pictureBox445.TabIndex = 448;
            this.pictureBox445.TabStop = false;
            this.pictureBox445.Tag = "coinScore";
            this.pictureBox445.Click += new System.EventHandler(this.pictureBox445_Click);
            // 
            // pictureBox446
            // 
            this.pictureBox446.BackColor = System.Drawing.Color.Orange;
            this.pictureBox446.Location = new System.Drawing.Point(489, 171);
            this.pictureBox446.Name = "pictureBox446";
            this.pictureBox446.Size = new System.Drawing.Size(10, 10);
            this.pictureBox446.TabIndex = 449;
            this.pictureBox446.TabStop = false;
            this.pictureBox446.Tag = "coinScore";
            // 
            // pictureBox447
            // 
            this.pictureBox447.BackColor = System.Drawing.Color.Orange;
            this.pictureBox447.Location = new System.Drawing.Point(489, 219);
            this.pictureBox447.Name = "pictureBox447";
            this.pictureBox447.Size = new System.Drawing.Size(10, 10);
            this.pictureBox447.TabIndex = 450;
            this.pictureBox447.TabStop = false;
            this.pictureBox447.Tag = "coinScore";
            // 
            // pictureBox448
            // 
            this.pictureBox448.BackColor = System.Drawing.Color.Orange;
            this.pictureBox448.Location = new System.Drawing.Point(653, 358);
            this.pictureBox448.Name = "pictureBox448";
            this.pictureBox448.Size = new System.Drawing.Size(10, 10);
            this.pictureBox448.TabIndex = 451;
            this.pictureBox448.TabStop = false;
            this.pictureBox448.Tag = "coinScore";
            // 
            // pictureBox449
            // 
            this.pictureBox449.Image = global::Game.Properties.Resources.coin;
            this.pictureBox449.Location = new System.Drawing.Point(1279, 32);
            this.pictureBox449.Name = "pictureBox449";
            this.pictureBox449.Size = new System.Drawing.Size(20, 20);
            this.pictureBox449.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox449.TabIndex = 452;
            this.pictureBox449.TabStop = false;
            this.pictureBox449.Tag = "PowerPellet";
            this.pictureBox449.Click += new System.EventHandler(this.pictureBox449_Click);
            // 
            // pictureBox450
            // 
            this.pictureBox450.Image = global::Game.Properties.Resources.coin;
            this.pictureBox450.Location = new System.Drawing.Point(1279, 553);
            this.pictureBox450.Name = "pictureBox450";
            this.pictureBox450.Size = new System.Drawing.Size(20, 20);
            this.pictureBox450.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox450.TabIndex = 453;
            this.pictureBox450.TabStop = false;
            this.pictureBox450.Tag = "PowerPellet";
            // 
            // pictureBox451
            // 
            this.pictureBox451.Image = global::Game.Properties.Resources.coin;
            this.pictureBox451.Location = new System.Drawing.Point(28, 553);
            this.pictureBox451.Name = "pictureBox451";
            this.pictureBox451.Size = new System.Drawing.Size(20, 20);
            this.pictureBox451.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox451.TabIndex = 454;
            this.pictureBox451.TabStop = false;
            this.pictureBox451.Tag = "PowerPellet";
            // 
            // pictureBox452
            // 
            this.pictureBox452.Image = global::Game.Properties.Resources.coin;
            this.pictureBox452.Location = new System.Drawing.Point(812, 300);
            this.pictureBox452.Name = "pictureBox452";
            this.pictureBox452.Size = new System.Drawing.Size(20, 20);
            this.pictureBox452.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox452.TabIndex = 455;
            this.pictureBox452.TabStop = false;
            this.pictureBox452.Tag = "PowerPellet";
            // 
            // pictureBox453
            // 
            this.pictureBox453.Image = global::Game.Properties.Resources.coin;
            this.pictureBox453.Location = new System.Drawing.Point(485, 305);
            this.pictureBox453.Name = "pictureBox453";
            this.pictureBox453.Size = new System.Drawing.Size(20, 20);
            this.pictureBox453.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox453.TabIndex = 456;
            this.pictureBox453.TabStop = false;
            this.pictureBox453.Tag = "PowerPellet";
            // 
            // pictureBox454
            // 
            this.pictureBox454.Image = global::Game.Properties.Resources.coin;
            this.pictureBox454.Location = new System.Drawing.Point(160, 38);
            this.pictureBox454.Name = "pictureBox454";
            this.pictureBox454.Size = new System.Drawing.Size(20, 20);
            this.pictureBox454.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox454.TabIndex = 457;
            this.pictureBox454.TabStop = false;
            this.pictureBox454.Tag = "PowerPellet";
            // 
            // pacman2
            // 
            this.pacman2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pacman2.Image = global::Game.Properties.Resources.pac_man;
            this.pacman2.Location = new System.Drawing.Point(650, 544);
            this.pacman2.Name = "pacman2";
            this.pacman2.Size = new System.Drawing.Size(36, 38);
            this.pacman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman2.TabIndex = 458;
            this.pacman2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Blue;
            this.pictureBox30.Location = new System.Drawing.Point(12, 12);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(106, 10);
            this.pictureBox30.TabIndex = 459;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Tag = "wall";
            this.pictureBox30.Visible = false;
            // 
            // pictureBox455
            // 
            this.pictureBox455.BackColor = System.Drawing.Color.Blue;
            this.pictureBox455.Location = new System.Drawing.Point(12, 12);
            this.pictureBox455.Name = "pictureBox455";
            this.pictureBox455.Size = new System.Drawing.Size(10, 30);
            this.pictureBox455.TabIndex = 460;
            this.pictureBox455.TabStop = false;
            this.pictureBox455.Tag = "wall";
            this.pictureBox455.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(906, 79);
            this.label1.TabIndex = 461;
            this.label1.Text = "PRESS SPACE TO BEGIN GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(194, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 79);
            this.label2.TabIndex = 462;
            this.label2.Text = "YOU LOST";
            // 
            // PacMan
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1341, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox455);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pacman2);
            this.Controls.Add(this.pictureBox454);
            this.Controls.Add(this.pictureBox453);
            this.Controls.Add(this.pictureBox452);
            this.Controls.Add(this.pictureBox451);
            this.Controls.Add(this.pictureBox450);
            this.Controls.Add(this.pictureBox449);
            this.Controls.Add(this.pictureBox448);
            this.Controls.Add(this.pictureBox447);
            this.Controls.Add(this.pictureBox446);
            this.Controls.Add(this.pictureBox445);
            this.Controls.Add(this.pictureBox444);
            this.Controls.Add(this.pictureBox48);
            this.Controls.Add(this.pictureBox47);
            this.Controls.Add(this.pictureBox443);
            this.Controls.Add(this.pictureBox442);
            this.Controls.Add(this.pictureBox441);
            this.Controls.Add(this.pictureBox427);
            this.Controls.Add(this.pictureBox428);
            this.Controls.Add(this.pictureBox429);
            this.Controls.Add(this.pictureBox430);
            this.Controls.Add(this.pictureBox431);
            this.Controls.Add(this.pictureBox432);
            this.Controls.Add(this.pictureBox433);
            this.Controls.Add(this.pictureBox434);
            this.Controls.Add(this.pictureBox435);
            this.Controls.Add(this.pictureBox436);
            this.Controls.Add(this.pictureBox437);
            this.Controls.Add(this.pictureBox438);
            this.Controls.Add(this.pictureBox439);
            this.Controls.Add(this.pictureBox440);
            this.Controls.Add(this.pictureBox424);
            this.Controls.Add(this.pictureBox425);
            this.Controls.Add(this.pictureBox426);
            this.Controls.Add(this.pictureBox415);
            this.Controls.Add(this.pictureBox416);
            this.Controls.Add(this.pictureBox417);
            this.Controls.Add(this.pictureBox418);
            this.Controls.Add(this.pictureBox419);
            this.Controls.Add(this.pictureBox420);
            this.Controls.Add(this.pictureBox421);
            this.Controls.Add(this.pictureBox422);
            this.Controls.Add(this.pictureBox423);
            this.Controls.Add(this.pictureBox412);
            this.Controls.Add(this.pictureBox413);
            this.Controls.Add(this.pictureBox414);
            this.Controls.Add(this.pictureBox398);
            this.Controls.Add(this.pictureBox399);
            this.Controls.Add(this.pictureBox400);
            this.Controls.Add(this.pictureBox401);
            this.Controls.Add(this.pictureBox402);
            this.Controls.Add(this.pictureBox403);
            this.Controls.Add(this.pictureBox404);
            this.Controls.Add(this.pictureBox405);
            this.Controls.Add(this.pictureBox406);
            this.Controls.Add(this.pictureBox407);
            this.Controls.Add(this.pictureBox408);
            this.Controls.Add(this.pictureBox409);
            this.Controls.Add(this.pictureBox410);
            this.Controls.Add(this.pictureBox411);
            this.Controls.Add(this.pictureBox391);
            this.Controls.Add(this.pictureBox392);
            this.Controls.Add(this.pictureBox393);
            this.Controls.Add(this.pictureBox394);
            this.Controls.Add(this.pictureBox395);
            this.Controls.Add(this.pictureBox396);
            this.Controls.Add(this.pictureBox397);
            this.Controls.Add(this.pictureBox373);
            this.Controls.Add(this.pictureBox374);
            this.Controls.Add(this.pictureBox375);
            this.Controls.Add(this.pictureBox376);
            this.Controls.Add(this.pictureBox377);
            this.Controls.Add(this.pictureBox378);
            this.Controls.Add(this.pictureBox379);
            this.Controls.Add(this.pictureBox380);
            this.Controls.Add(this.pictureBox381);
            this.Controls.Add(this.pictureBox382);
            this.Controls.Add(this.pictureBox383);
            this.Controls.Add(this.pictureBox384);
            this.Controls.Add(this.pictureBox385);
            this.Controls.Add(this.pictureBox386);
            this.Controls.Add(this.pictureBox387);
            this.Controls.Add(this.pictureBox388);
            this.Controls.Add(this.pictureBox389);
            this.Controls.Add(this.pictureBox390);
            this.Controls.Add(this.pictureBox355);
            this.Controls.Add(this.pictureBox356);
            this.Controls.Add(this.pictureBox357);
            this.Controls.Add(this.pictureBox358);
            this.Controls.Add(this.pictureBox359);
            this.Controls.Add(this.pictureBox360);
            this.Controls.Add(this.pictureBox361);
            this.Controls.Add(this.pictureBox362);
            this.Controls.Add(this.pictureBox363);
            this.Controls.Add(this.pictureBox364);
            this.Controls.Add(this.pictureBox365);
            this.Controls.Add(this.pictureBox366);
            this.Controls.Add(this.pictureBox367);
            this.Controls.Add(this.pictureBox368);
            this.Controls.Add(this.pictureBox369);
            this.Controls.Add(this.pictureBox370);
            this.Controls.Add(this.pictureBox371);
            this.Controls.Add(this.pictureBox372);
            this.Controls.Add(this.pictureBox337);
            this.Controls.Add(this.pictureBox338);
            this.Controls.Add(this.pictureBox339);
            this.Controls.Add(this.pictureBox340);
            this.Controls.Add(this.pictureBox341);
            this.Controls.Add(this.pictureBox342);
            this.Controls.Add(this.pictureBox343);
            this.Controls.Add(this.pictureBox344);
            this.Controls.Add(this.pictureBox345);
            this.Controls.Add(this.pictureBox346);
            this.Controls.Add(this.pictureBox347);
            this.Controls.Add(this.pictureBox348);
            this.Controls.Add(this.pictureBox349);
            this.Controls.Add(this.pictureBox350);
            this.Controls.Add(this.pictureBox351);
            this.Controls.Add(this.pictureBox352);
            this.Controls.Add(this.pictureBox353);
            this.Controls.Add(this.pictureBox354);
            this.Controls.Add(this.pictureBox319);
            this.Controls.Add(this.pictureBox320);
            this.Controls.Add(this.pictureBox321);
            this.Controls.Add(this.pictureBox322);
            this.Controls.Add(this.pictureBox323);
            this.Controls.Add(this.pictureBox324);
            this.Controls.Add(this.pictureBox325);
            this.Controls.Add(this.pictureBox326);
            this.Controls.Add(this.pictureBox327);
            this.Controls.Add(this.pictureBox328);
            this.Controls.Add(this.pictureBox329);
            this.Controls.Add(this.pictureBox330);
            this.Controls.Add(this.pictureBox331);
            this.Controls.Add(this.pictureBox332);
            this.Controls.Add(this.pictureBox333);
            this.Controls.Add(this.pictureBox334);
            this.Controls.Add(this.pictureBox335);
            this.Controls.Add(this.pictureBox336);
            this.Controls.Add(this.pictureBox301);
            this.Controls.Add(this.pictureBox302);
            this.Controls.Add(this.pictureBox303);
            this.Controls.Add(this.pictureBox304);
            this.Controls.Add(this.pictureBox305);
            this.Controls.Add(this.pictureBox306);
            this.Controls.Add(this.pictureBox307);
            this.Controls.Add(this.pictureBox308);
            this.Controls.Add(this.pictureBox309);
            this.Controls.Add(this.pictureBox310);
            this.Controls.Add(this.pictureBox311);
            this.Controls.Add(this.pictureBox312);
            this.Controls.Add(this.pictureBox313);
            this.Controls.Add(this.pictureBox314);
            this.Controls.Add(this.pictureBox315);
            this.Controls.Add(this.pictureBox316);
            this.Controls.Add(this.pictureBox317);
            this.Controls.Add(this.pictureBox318);
            this.Controls.Add(this.pictureBox283);
            this.Controls.Add(this.pictureBox284);
            this.Controls.Add(this.pictureBox285);
            this.Controls.Add(this.pictureBox286);
            this.Controls.Add(this.pictureBox287);
            this.Controls.Add(this.pictureBox288);
            this.Controls.Add(this.pictureBox289);
            this.Controls.Add(this.pictureBox290);
            this.Controls.Add(this.pictureBox291);
            this.Controls.Add(this.pictureBox292);
            this.Controls.Add(this.pictureBox293);
            this.Controls.Add(this.pictureBox294);
            this.Controls.Add(this.pictureBox295);
            this.Controls.Add(this.pictureBox296);
            this.Controls.Add(this.pictureBox297);
            this.Controls.Add(this.pictureBox298);
            this.Controls.Add(this.pictureBox299);
            this.Controls.Add(this.pictureBox300);
            this.Controls.Add(this.pictureBox265);
            this.Controls.Add(this.pictureBox266);
            this.Controls.Add(this.pictureBox267);
            this.Controls.Add(this.pictureBox268);
            this.Controls.Add(this.pictureBox269);
            this.Controls.Add(this.pictureBox270);
            this.Controls.Add(this.pictureBox271);
            this.Controls.Add(this.pictureBox272);
            this.Controls.Add(this.pictureBox273);
            this.Controls.Add(this.pictureBox274);
            this.Controls.Add(this.pictureBox275);
            this.Controls.Add(this.pictureBox276);
            this.Controls.Add(this.pictureBox277);
            this.Controls.Add(this.pictureBox278);
            this.Controls.Add(this.pictureBox279);
            this.Controls.Add(this.pictureBox280);
            this.Controls.Add(this.pictureBox281);
            this.Controls.Add(this.pictureBox282);
            this.Controls.Add(this.pictureBox247);
            this.Controls.Add(this.pictureBox248);
            this.Controls.Add(this.pictureBox249);
            this.Controls.Add(this.pictureBox250);
            this.Controls.Add(this.pictureBox251);
            this.Controls.Add(this.pictureBox252);
            this.Controls.Add(this.pictureBox253);
            this.Controls.Add(this.pictureBox254);
            this.Controls.Add(this.pictureBox255);
            this.Controls.Add(this.pictureBox256);
            this.Controls.Add(this.pictureBox257);
            this.Controls.Add(this.pictureBox258);
            this.Controls.Add(this.pictureBox259);
            this.Controls.Add(this.pictureBox260);
            this.Controls.Add(this.pictureBox261);
            this.Controls.Add(this.pictureBox262);
            this.Controls.Add(this.pictureBox263);
            this.Controls.Add(this.pictureBox264);
            this.Controls.Add(this.pictureBox229);
            this.Controls.Add(this.pictureBox230);
            this.Controls.Add(this.pictureBox231);
            this.Controls.Add(this.pictureBox232);
            this.Controls.Add(this.pictureBox233);
            this.Controls.Add(this.pictureBox234);
            this.Controls.Add(this.pictureBox235);
            this.Controls.Add(this.pictureBox236);
            this.Controls.Add(this.pictureBox237);
            this.Controls.Add(this.pictureBox238);
            this.Controls.Add(this.pictureBox239);
            this.Controls.Add(this.pictureBox240);
            this.Controls.Add(this.pictureBox241);
            this.Controls.Add(this.pictureBox242);
            this.Controls.Add(this.pictureBox243);
            this.Controls.Add(this.pictureBox244);
            this.Controls.Add(this.pictureBox245);
            this.Controls.Add(this.pictureBox246);
            this.Controls.Add(this.pictureBox205);
            this.Controls.Add(this.pictureBox206);
            this.Controls.Add(this.pictureBox207);
            this.Controls.Add(this.pictureBox208);
            this.Controls.Add(this.pictureBox209);
            this.Controls.Add(this.pictureBox210);
            this.Controls.Add(this.pictureBox211);
            this.Controls.Add(this.pictureBox212);
            this.Controls.Add(this.pictureBox213);
            this.Controls.Add(this.pictureBox214);
            this.Controls.Add(this.pictureBox215);
            this.Controls.Add(this.pictureBox216);
            this.Controls.Add(this.pictureBox217);
            this.Controls.Add(this.pictureBox218);
            this.Controls.Add(this.pictureBox219);
            this.Controls.Add(this.pictureBox220);
            this.Controls.Add(this.pictureBox221);
            this.Controls.Add(this.pictureBox222);
            this.Controls.Add(this.pictureBox223);
            this.Controls.Add(this.pictureBox224);
            this.Controls.Add(this.pictureBox225);
            this.Controls.Add(this.pictureBox226);
            this.Controls.Add(this.pictureBox227);
            this.Controls.Add(this.pictureBox228);
            this.Controls.Add(this.pictureBox181);
            this.Controls.Add(this.pictureBox182);
            this.Controls.Add(this.pictureBox183);
            this.Controls.Add(this.pictureBox184);
            this.Controls.Add(this.pictureBox185);
            this.Controls.Add(this.pictureBox186);
            this.Controls.Add(this.pictureBox187);
            this.Controls.Add(this.pictureBox188);
            this.Controls.Add(this.pictureBox189);
            this.Controls.Add(this.pictureBox190);
            this.Controls.Add(this.pictureBox191);
            this.Controls.Add(this.pictureBox192);
            this.Controls.Add(this.pictureBox193);
            this.Controls.Add(this.pictureBox194);
            this.Controls.Add(this.pictureBox195);
            this.Controls.Add(this.pictureBox196);
            this.Controls.Add(this.pictureBox197);
            this.Controls.Add(this.pictureBox198);
            this.Controls.Add(this.pictureBox199);
            this.Controls.Add(this.pictureBox200);
            this.Controls.Add(this.pictureBox201);
            this.Controls.Add(this.pictureBox202);
            this.Controls.Add(this.pictureBox203);
            this.Controls.Add(this.pictureBox204);
            this.Controls.Add(this.pictureBox157);
            this.Controls.Add(this.pictureBox158);
            this.Controls.Add(this.pictureBox159);
            this.Controls.Add(this.pictureBox160);
            this.Controls.Add(this.pictureBox161);
            this.Controls.Add(this.pictureBox162);
            this.Controls.Add(this.pictureBox163);
            this.Controls.Add(this.pictureBox164);
            this.Controls.Add(this.pictureBox165);
            this.Controls.Add(this.pictureBox166);
            this.Controls.Add(this.pictureBox167);
            this.Controls.Add(this.pictureBox168);
            this.Controls.Add(this.pictureBox169);
            this.Controls.Add(this.pictureBox170);
            this.Controls.Add(this.pictureBox171);
            this.Controls.Add(this.pictureBox172);
            this.Controls.Add(this.pictureBox173);
            this.Controls.Add(this.pictureBox174);
            this.Controls.Add(this.pictureBox175);
            this.Controls.Add(this.pictureBox176);
            this.Controls.Add(this.pictureBox177);
            this.Controls.Add(this.pictureBox178);
            this.Controls.Add(this.pictureBox179);
            this.Controls.Add(this.pictureBox180);
            this.Controls.Add(this.pictureBox153);
            this.Controls.Add(this.pictureBox154);
            this.Controls.Add(this.pictureBox155);
            this.Controls.Add(this.pictureBox156);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.pictureBox150);
            this.Controls.Add(this.pictureBox151);
            this.Controls.Add(this.pictureBox152);
            this.Controls.Add(this.pictureBox130);
            this.Controls.Add(this.pictureBox131);
            this.Controls.Add(this.pictureBox132);
            this.Controls.Add(this.pictureBox133);
            this.Controls.Add(this.pictureBox134);
            this.Controls.Add(this.pictureBox135);
            this.Controls.Add(this.pictureBox136);
            this.Controls.Add(this.pictureBox137);
            this.Controls.Add(this.pictureBox138);
            this.Controls.Add(this.pictureBox139);
            this.Controls.Add(this.pictureBox140);
            this.Controls.Add(this.pictureBox141);
            this.Controls.Add(this.pictureBox142);
            this.Controls.Add(this.pictureBox143);
            this.Controls.Add(this.pictureBox144);
            this.Controls.Add(this.pictureBox145);
            this.Controls.Add(this.pictureBox146);
            this.Controls.Add(this.pictureBox147);
            this.Controls.Add(this.pictureBox148);
            this.Controls.Add(this.pictureBox149);
            this.Controls.Add(this.pictureBox120);
            this.Controls.Add(this.pictureBox121);
            this.Controls.Add(this.pictureBox122);
            this.Controls.Add(this.pictureBox123);
            this.Controls.Add(this.pictureBox124);
            this.Controls.Add(this.pictureBox125);
            this.Controls.Add(this.pictureBox126);
            this.Controls.Add(this.pictureBox127);
            this.Controls.Add(this.pictureBox128);
            this.Controls.Add(this.pictureBox129);
            this.Controls.Add(this.pictureBox115);
            this.Controls.Add(this.pictureBox116);
            this.Controls.Add(this.pictureBox117);
            this.Controls.Add(this.pictureBox118);
            this.Controls.Add(this.pictureBox119);
            this.Controls.Add(this.pictureBox97);
            this.Controls.Add(this.pictureBox98);
            this.Controls.Add(this.pictureBox99);
            this.Controls.Add(this.pictureBox100);
            this.Controls.Add(this.pictureBox101);
            this.Controls.Add(this.pictureBox102);
            this.Controls.Add(this.pictureBox103);
            this.Controls.Add(this.pictureBox104);
            this.Controls.Add(this.pictureBox105);
            this.Controls.Add(this.pictureBox106);
            this.Controls.Add(this.pictureBox107);
            this.Controls.Add(this.pictureBox108);
            this.Controls.Add(this.pictureBox109);
            this.Controls.Add(this.pictureBox110);
            this.Controls.Add(this.pictureBox111);
            this.Controls.Add(this.pictureBox112);
            this.Controls.Add(this.pictureBox113);
            this.Controls.Add(this.pictureBox114);
            this.Controls.Add(this.pictureBox79);
            this.Controls.Add(this.pictureBox80);
            this.Controls.Add(this.pictureBox81);
            this.Controls.Add(this.pictureBox82);
            this.Controls.Add(this.pictureBox83);
            this.Controls.Add(this.pictureBox84);
            this.Controls.Add(this.pictureBox85);
            this.Controls.Add(this.pictureBox86);
            this.Controls.Add(this.pictureBox87);
            this.Controls.Add(this.pictureBox88);
            this.Controls.Add(this.pictureBox89);
            this.Controls.Add(this.pictureBox90);
            this.Controls.Add(this.pictureBox91);
            this.Controls.Add(this.pictureBox92);
            this.Controls.Add(this.pictureBox93);
            this.Controls.Add(this.pictureBox94);
            this.Controls.Add(this.pictureBox95);
            this.Controls.Add(this.pictureBox96);
            this.Controls.Add(this.pictureBox61);
            this.Controls.Add(this.pictureBox62);
            this.Controls.Add(this.pictureBox63);
            this.Controls.Add(this.pictureBox64);
            this.Controls.Add(this.pictureBox65);
            this.Controls.Add(this.pictureBox66);
            this.Controls.Add(this.pictureBox67);
            this.Controls.Add(this.pictureBox68);
            this.Controls.Add(this.pictureBox69);
            this.Controls.Add(this.pictureBox70);
            this.Controls.Add(this.pictureBox71);
            this.Controls.Add(this.pictureBox72);
            this.Controls.Add(this.pictureBox73);
            this.Controls.Add(this.pictureBox74);
            this.Controls.Add(this.pictureBox75);
            this.Controls.Add(this.pictureBox76);
            this.Controls.Add(this.pictureBox77);
            this.Controls.Add(this.pictureBox78);
            this.Controls.Add(this.pictureBox55);
            this.Controls.Add(this.pictureBox56);
            this.Controls.Add(this.pictureBox57);
            this.Controls.Add(this.pictureBox58);
            this.Controls.Add(this.pictureBox59);
            this.Controls.Add(this.pictureBox60);
            this.Controls.Add(this.pictureBox49);
            this.Controls.Add(this.pictureBox50);
            this.Controls.Add(this.pictureBox51);
            this.Controls.Add(this.pictureBox52);
            this.Controls.Add(this.pictureBox53);
            this.Controls.Add(this.pictureBox54);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.pictureBox44);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.pictureBox46);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox41);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Score);
            this.Name = "PacMan";
            this.Tag = "coinScore";
            this.Text = "PacMan";
            this.Load += new System.EventHandler(this.PacMan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox106)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox107)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox108)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox109)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox112)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox113)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox114)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox115)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox116)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox117)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox118)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox119)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox120)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox121)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox122)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox124)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox129)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox130)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox131)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox132)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox133)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox134)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox135)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox136)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox137)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox138)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox139)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox140)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox141)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox142)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox146)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox147)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox148)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox149)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox150)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox151)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox152)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox153)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox154)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox155)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox156)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox157)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox158)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox159)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox160)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox161)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox162)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox163)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox164)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox165)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox166)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox167)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox168)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox169)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox170)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox171)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox172)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox173)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox174)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox175)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox176)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox177)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox178)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox179)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox180)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox181)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox182)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox183)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox184)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox185)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox186)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox187)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox188)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox189)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox190)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox191)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox192)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox193)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox194)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox195)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox196)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox197)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox198)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox199)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox201)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox202)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox203)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox204)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox205)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox206)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox207)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox208)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox209)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox210)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox211)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox212)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox213)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox214)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox215)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox216)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox217)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox218)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox219)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox220)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox221)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox222)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox223)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox224)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox225)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox226)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox227)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox228)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox229)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox230)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox231)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox232)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox233)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox234)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox235)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox236)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox237)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox238)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox239)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox240)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox241)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox242)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox243)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox244)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox245)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox246)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox247)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox248)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox249)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox250)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox251)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox252)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox253)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox254)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox255)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox256)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox257)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox258)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox259)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox260)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox261)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox262)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox263)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox264)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox265)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox266)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox267)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox268)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox269)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox270)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox271)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox272)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox273)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox274)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox275)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox276)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox277)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox278)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox279)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox280)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox281)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox282)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox283)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox284)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox285)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox286)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox287)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox288)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox289)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox290)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox291)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox292)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox293)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox294)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox295)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox296)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox297)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox298)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox299)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox300)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox301)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox302)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox303)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox304)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox305)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox306)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox307)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox308)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox309)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox310)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox311)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox312)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox313)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox314)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox315)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox316)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox317)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox318)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox319)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox320)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox321)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox322)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox323)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox324)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox325)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox326)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox327)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox328)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox329)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox330)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox331)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox332)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox333)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox334)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox335)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox336)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox337)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox338)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox339)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox340)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox341)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox342)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox343)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox344)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox345)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox346)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox347)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox348)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox349)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox350)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox351)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox352)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox353)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox354)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox355)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox356)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox357)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox358)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox359)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox361)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox362)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox363)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox364)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox365)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox366)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox367)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox368)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox369)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox370)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox371)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox372)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox373)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox374)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox375)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox376)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox377)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox378)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox379)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox380)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox381)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox382)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox383)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox384)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox385)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox386)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox387)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox388)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox389)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox390)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox391)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox392)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox393)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox394)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox395)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox396)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox397)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox398)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox399)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox400)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox401)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox402)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox403)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox404)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox405)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox406)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox407)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox408)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox409)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox410)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox411)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox412)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox413)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox414)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox415)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox416)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox417)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox418)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox419)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox420)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox421)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox422)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox423)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox424)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox425)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox426)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox428)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox429)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox430)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox431)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox432)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox433)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox434)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox435)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox436)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox437)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox438)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox439)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox440)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox427)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox441)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox442)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox443)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox444)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox445)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox446)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox447)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox448)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox449)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox450)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox451)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox452)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox453)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox454)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox455)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label Score;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox yellowGhost;
        private PictureBox redGhost;
        private PictureBox pinkGhost;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox36;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox pictureBox40;
        private PictureBox pictureBox41;
        private PictureBox pictureBox43;
        private PictureBox pictureBox44;
        private PictureBox pictureBox45;
        private PictureBox pictureBox46;
        private PictureBox pictureBox49;
        private PictureBox pictureBox50;
        private PictureBox pictureBox51;
        private PictureBox pictureBox52;
        private PictureBox pictureBox53;
        private PictureBox pictureBox54;
        private PictureBox pictureBox55;
        private PictureBox pictureBox56;
        private PictureBox pictureBox57;
        private PictureBox pictureBox58;
        private PictureBox pictureBox59;
        private PictureBox pictureBox60;
        private PictureBox pictureBox61;
        private PictureBox pictureBox62;
        private PictureBox pictureBox63;
        private PictureBox pictureBox64;
        private PictureBox pictureBox65;
        private PictureBox pictureBox66;
        private PictureBox pictureBox67;
        private PictureBox pictureBox68;
        private PictureBox pictureBox69;
        private PictureBox pictureBox70;
        private PictureBox pictureBox71;
        private PictureBox pictureBox72;
        private PictureBox pictureBox73;
        private PictureBox pictureBox74;
        private PictureBox pictureBox75;
        private PictureBox pictureBox76;
        private PictureBox pictureBox77;
        private PictureBox pictureBox78;
        private PictureBox pictureBox79;
        private PictureBox pictureBox80;
        private PictureBox pictureBox81;
        private PictureBox pictureBox82;
        private PictureBox pictureBox83;
        private PictureBox pictureBox84;
        private PictureBox pictureBox85;
        private PictureBox pictureBox86;
        private PictureBox pictureBox87;
        private PictureBox pictureBox88;
        private PictureBox pictureBox89;
        private PictureBox pictureBox90;
        private PictureBox pictureBox91;
        private PictureBox pictureBox92;
        private PictureBox pictureBox93;
        private PictureBox pictureBox94;
        private PictureBox pictureBox95;
        private PictureBox pictureBox96;
        private PictureBox pictureBox97;
        private PictureBox pictureBox98;
        private PictureBox pictureBox99;
        private PictureBox pictureBox100;
        private PictureBox pictureBox101;
        private PictureBox pictureBox102;
        private PictureBox pictureBox103;
        private PictureBox pictureBox104;
        private PictureBox pictureBox105;
        private PictureBox pictureBox106;
        private PictureBox pictureBox107;
        private PictureBox pictureBox108;
        private PictureBox pictureBox109;
        private PictureBox pictureBox110;
        private PictureBox pictureBox111;
        private PictureBox pictureBox112;
        private PictureBox pictureBox113;
        private PictureBox pictureBox114;
        private PictureBox pictureBox115;
        private PictureBox pictureBox116;
        private PictureBox pictureBox117;
        private PictureBox pictureBox118;
        private PictureBox pictureBox119;
        private PictureBox pictureBox120;
        private PictureBox pictureBox121;
        private PictureBox pictureBox122;
        private PictureBox pictureBox123;
        private PictureBox pictureBox124;
        private PictureBox pictureBox125;
        private PictureBox pictureBox126;
        private PictureBox pictureBox127;
        private PictureBox pictureBox128;
        private PictureBox pictureBox129;
        private PictureBox pictureBox130;
        private PictureBox pictureBox131;
        private PictureBox pictureBox132;
        private PictureBox pictureBox133;
        private PictureBox pictureBox134;
        private PictureBox pictureBox135;
        private PictureBox pictureBox136;
        private PictureBox pictureBox137;
        private PictureBox pictureBox138;
        private PictureBox pictureBox139;
        private PictureBox pictureBox140;
        private PictureBox pictureBox141;
        private PictureBox pictureBox142;
        private PictureBox pictureBox143;
        private PictureBox pictureBox144;
        private PictureBox pictureBox145;
        private PictureBox pictureBox146;
        private PictureBox pictureBox147;
        private PictureBox pictureBox148;
        private PictureBox pictureBox149;

        private void pictureBox42_Click(object sender, EventArgs e)
        {


        }

        private PictureBox pictureBox42;
        private PictureBox pictureBox150;
        private PictureBox pictureBox151;
        private PictureBox pictureBox152;
        private PictureBox pictureBox153;
        private PictureBox pictureBox154;
        private PictureBox pictureBox155;
        private PictureBox pictureBox156;
        private PictureBox pictureBox157;
        private PictureBox pictureBox158;
        private PictureBox pictureBox159;
        private PictureBox pictureBox160;
        private PictureBox pictureBox161;
        private PictureBox pictureBox162;
        private PictureBox pictureBox163;
        private PictureBox pictureBox164;
        private PictureBox pictureBox165;
        private PictureBox pictureBox166;
        private PictureBox pictureBox167;
        private PictureBox pictureBox168;
        private PictureBox pictureBox169;
        private PictureBox pictureBox170;
        private PictureBox pictureBox171;
        private PictureBox pictureBox172;
        private PictureBox pictureBox173;
        private PictureBox pictureBox174;
        private PictureBox pictureBox175;
        private PictureBox pictureBox176;
        private PictureBox pictureBox177;
        private PictureBox pictureBox178;
        private PictureBox pictureBox179;
        private PictureBox pictureBox180;
        private PictureBox pictureBox181;
        private PictureBox pictureBox182;
        private PictureBox pictureBox183;
        private PictureBox pictureBox184;
        private PictureBox pictureBox185;
        private PictureBox pictureBox186;
        private PictureBox pictureBox187;
        private PictureBox pictureBox188;
        private PictureBox pictureBox189;
        private PictureBox pictureBox190;
        private PictureBox pictureBox191;
        private PictureBox pictureBox192;
        private PictureBox pictureBox193;
        private PictureBox pictureBox194;
        private PictureBox pictureBox195;
        private PictureBox pictureBox196;
        private PictureBox pictureBox197;
        private PictureBox pictureBox198;
        private PictureBox pictureBox199;
        private PictureBox pictureBox200;
        private PictureBox pictureBox201;
        private PictureBox pictureBox202;
        private PictureBox pictureBox203;
        private PictureBox pictureBox204;
        private PictureBox pictureBox205;
        private PictureBox pictureBox206;
        private PictureBox pictureBox207;
        private PictureBox pictureBox208;
        private PictureBox pictureBox209;
        private PictureBox pictureBox210;
        private PictureBox pictureBox211;
        private PictureBox pictureBox212;
        private PictureBox pictureBox213;
        private PictureBox pictureBox214;
        private PictureBox pictureBox215;
        private PictureBox pictureBox216;
        private PictureBox pictureBox217;
        private PictureBox pictureBox218;
        private PictureBox pictureBox219;
        private PictureBox pictureBox220;
        private PictureBox pictureBox221;
        private PictureBox pictureBox222;
        private PictureBox pictureBox223;
        private PictureBox pictureBox224;
        private PictureBox pictureBox225;
        private PictureBox pictureBox226;
        private PictureBox pictureBox227;
        private PictureBox pictureBox228;
        private PictureBox pictureBox229;
        private PictureBox pictureBox230;
        private PictureBox pictureBox231;
        private PictureBox pictureBox232;
        private PictureBox pictureBox233;
        private PictureBox pictureBox234;
        private PictureBox pictureBox235;
        private PictureBox pictureBox236;
        private PictureBox pictureBox237;
        private PictureBox pictureBox238;
        private PictureBox pictureBox239;
        private PictureBox pictureBox240;
        private PictureBox pictureBox241;
        private PictureBox pictureBox242;
        private PictureBox pictureBox243;
        private PictureBox pictureBox244;
        private PictureBox pictureBox245;
        private PictureBox pictureBox246;
        private PictureBox pictureBox247;
        private PictureBox pictureBox248;
        private PictureBox pictureBox249;
        private PictureBox pictureBox250;
        private PictureBox pictureBox251;
        private PictureBox pictureBox252;
        private PictureBox pictureBox253;
        private PictureBox pictureBox254;
        private PictureBox pictureBox255;
        private PictureBox pictureBox256;
        private PictureBox pictureBox257;
        private PictureBox pictureBox258;
        private PictureBox pictureBox259;
        private PictureBox pictureBox260;
        private PictureBox pictureBox261;
        private PictureBox pictureBox262;
        private PictureBox pictureBox263;
        private PictureBox pictureBox264;
        private PictureBox pictureBox265;
        private PictureBox pictureBox266;
        private PictureBox pictureBox267;
        private PictureBox pictureBox268;
        private PictureBox pictureBox269;
        private PictureBox pictureBox270;
        private PictureBox pictureBox271;
        private PictureBox pictureBox272;
        private PictureBox pictureBox273;
        private PictureBox pictureBox274;
        private PictureBox pictureBox275;
        private PictureBox pictureBox276;
        private PictureBox pictureBox277;
        private PictureBox pictureBox278;
        private PictureBox pictureBox279;
        private PictureBox pictureBox280;
        private PictureBox pictureBox281;
        private PictureBox pictureBox282;
        private PictureBox pictureBox283;
        private PictureBox pictureBox284;
        private PictureBox pictureBox285;
        private PictureBox pictureBox286;
        private PictureBox pictureBox287;
        private PictureBox pictureBox288;
        private PictureBox pictureBox289;
        private PictureBox pictureBox290;
        private PictureBox pictureBox291;
        private PictureBox pictureBox292;
        private PictureBox pictureBox293;
        private PictureBox pictureBox294;
        private PictureBox pictureBox295;
        private PictureBox pictureBox296;
        private PictureBox pictureBox297;
        private PictureBox pictureBox298;
        private PictureBox pictureBox299;
        private PictureBox pictureBox300;
        private PictureBox pictureBox301;
        private PictureBox pictureBox302;
        private PictureBox pictureBox303;
        private PictureBox pictureBox304;
        private PictureBox pictureBox305;
        private PictureBox pictureBox306;
        private PictureBox pictureBox307;
        private PictureBox pictureBox308;
        private PictureBox pictureBox309;
        private PictureBox pictureBox310;
        private PictureBox pictureBox311;
        private PictureBox pictureBox312;
        private PictureBox pictureBox313;
        private PictureBox pictureBox314;
        private PictureBox pictureBox315;
        private PictureBox pictureBox316;
        private PictureBox pictureBox317;
        private PictureBox pictureBox318;
        private PictureBox pictureBox319;
        private PictureBox pictureBox320;
        private PictureBox pictureBox321;
        private PictureBox pictureBox322;
        private PictureBox pictureBox323;
        private PictureBox pictureBox324;
        private PictureBox pictureBox325;
        private PictureBox pictureBox326;
        private PictureBox pictureBox327;
        private PictureBox pictureBox328;
        private PictureBox pictureBox329;
        private PictureBox pictureBox330;
        private PictureBox pictureBox331;
        private PictureBox pictureBox332;
        private PictureBox pictureBox333;
        private PictureBox pictureBox334;
        private PictureBox pictureBox335;
        private PictureBox pictureBox336;
        private PictureBox pictureBox337;
        private PictureBox pictureBox338;
        private PictureBox pictureBox339;
        private PictureBox pictureBox340;
        private PictureBox pictureBox341;
        private PictureBox pictureBox342;
        private PictureBox pictureBox343;
        private PictureBox pictureBox344;
        private PictureBox pictureBox345;
        private PictureBox pictureBox346;
        private PictureBox pictureBox347;
        private PictureBox pictureBox348;
        private PictureBox pictureBox349;
        private PictureBox pictureBox350;
        private PictureBox pictureBox351;
        private PictureBox pictureBox352;
        private PictureBox pictureBox353;
        private PictureBox pictureBox354;
        private PictureBox pictureBox355;
        private PictureBox pictureBox356;
        private PictureBox pictureBox357;
        private PictureBox pictureBox358;
        private PictureBox pictureBox359;
        private PictureBox pictureBox360;
        private PictureBox pictureBox361;
        private PictureBox pictureBox362;
        private PictureBox pictureBox363;
        private PictureBox pictureBox364;
        private PictureBox pictureBox365;
        private PictureBox pictureBox366;
        private PictureBox pictureBox367;
        private PictureBox pictureBox368;
        private PictureBox pictureBox369;
        private PictureBox pictureBox370;
        private PictureBox pictureBox371;
        private PictureBox pictureBox372;
        private PictureBox pictureBox373;
        private PictureBox pictureBox374;
        private PictureBox pictureBox375;
        private PictureBox pictureBox376;
        private PictureBox pictureBox377;
        private PictureBox pictureBox378;
        private PictureBox pictureBox379;
        private PictureBox pictureBox380;
        private PictureBox pictureBox381;
        private PictureBox pictureBox382;
        private PictureBox pictureBox383;
        private PictureBox pictureBox384;
        private PictureBox pictureBox385;
        private PictureBox pictureBox386;
        private PictureBox pictureBox387;
        private PictureBox pictureBox388;
        private PictureBox pictureBox389;
        private PictureBox pictureBox390;
        private PictureBox pictureBox391;
        private PictureBox pictureBox392;
        private PictureBox pictureBox393;
        private PictureBox pictureBox394;
        private PictureBox pictureBox395;
        private PictureBox pictureBox396;
        private PictureBox pictureBox397;
        private PictureBox pictureBox398;
        private PictureBox pictureBox399;
        private PictureBox pictureBox400;
        private PictureBox pictureBox401;
        private PictureBox pictureBox402;
        private PictureBox pictureBox403;
        private PictureBox pictureBox404;
        private PictureBox pictureBox405;
        private PictureBox pictureBox406;
        private PictureBox pictureBox407;
        private PictureBox pictureBox408;
        private PictureBox pictureBox409;
        private PictureBox pictureBox410;
        private PictureBox pictureBox411;
        private PictureBox pictureBox412;
        private PictureBox pictureBox413;
        private PictureBox pictureBox414;
        private PictureBox pictureBox415;
        private PictureBox pictureBox416;
        private PictureBox pictureBox417;
        private PictureBox pictureBox418;
        private PictureBox pictureBox419;
        private PictureBox pictureBox420;
        private PictureBox pictureBox421;
        private PictureBox pictureBox422;
        private PictureBox pictureBox423;
        private PictureBox pictureBox424;
        private PictureBox pictureBox425;
        private PictureBox pictureBox426;
        private PictureBox pictureBox428;
        private PictureBox pictureBox429;
        private PictureBox pictureBox430;
        private PictureBox pictureBox431;
        private PictureBox pictureBox432;
        private PictureBox pictureBox433;
        private PictureBox pictureBox434;
        private PictureBox pictureBox435;
        private PictureBox pictureBox436;
        private PictureBox pictureBox437;
        private PictureBox pictureBox438;
        private PictureBox pictureBox439;
        private PictureBox pictureBox440;
        private PictureBox pictureBox427;
        private PictureBox pictureBox441;
        private PictureBox pictureBox442;
        private PictureBox pictureBox443;

        private void pictureBox279_Click(object sender, EventArgs e)
        {

        }

        private ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox47;
        private PictureBox pictureBox48;
        private PictureBox pictureBox444;

        private void pictureBox444_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox445;
        private PictureBox pictureBox446;

        private void pictureBox445_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox447;
        private PictureBox pictureBox448;
        private PictureBox pictureBox449;

        

        private void pictureBox449_Click(object sender, EventArgs e)
        {

        }

        private PictureBox pictureBox450;



        private PictureBox pictureBox451;
        private PictureBox pictureBox452;
        private PictureBox pictureBox453;
        private PictureBox pictureBox454;

        

        

        private void gameTimer(object sender, EventArgs e)
        {
            if(score == 477)
            {
                gameWon();
            }
            pictureBox30.Visible = false;
            pictureBox455.Visible = false;
            label2.Visible = false;
            Score.Text = "Score: " + score;
            Point pacmanPosition = new Point(pacman2.Left, pacman2.Top);
            Point redGhostPosition = new Point(redGhost.Left, redGhost.Top);
            Point pinkGhostPosition = new Point(pinkGhost.Left, pinkGhost.Top);
            Point yellowGhostPosition = new Point(pinkGhost.Left, pinkGhost.Top);
            chasePacman(pacmanPosition, ref redGhostPosition, redGhostSpeed, redGhost.Width, redGhost.Height);
            chasePacman(pacmanPosition, ref pinkGhostPosition, pinkGhostSpeed, pinkGhost.Width, pinkGhost.Height);
            chasePacman(pacmanPosition, ref yellowGhostPosition, yellowGhostSpeed, yellowGhost.Width, yellowGhost.Height);


            redGhost.Left = redGhostPosition.X;
            redGhost.Top = redGhostPosition.Y;

            pinkGhost.Left = pinkGhostPosition.X;
            pinkGhost.Top = pinkGhostPosition.Y;

            yellowGhost.Left = yellowGhostPosition.X;
            yellowGhost.Top = yellowGhostPosition.Y;



            if (pacman2.Left < -10)
            {
                pacman2.Left = 1357;
            }
            if (pacman2.Left > 1357)
            {
                pacman2.Left = -10;
            }
            
            Score.Text = "Score: " + score;
            if (left == true)
            {
                pacman2.Image = Properties.Resources.ezgif_com_rotate;
                pacman2.Left -= playerSpeed;                
                
            }
            if (right == true)
            {
                pacman2.Left += playerSpeed;
                pacman2.Image = Properties.Resources.pac_man;
            }
            if (down == true)
            {
                pacman2.Top += playerSpeed;
                pacman2.Image = Properties.Resources.ezgif_com_rotate__1_;
            }
            if (up == true)
            {
                pacman2.Top -= playerSpeed;
                pacman2.Image = Properties.Resources.ezgif_com_rotate__2_;
            }
            directionBlock = "";
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coinScore" && x.Visible == true)
                    {
                        if (pacman2.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }
                    if ((string)x.Tag == "PowerPellet" && x.Visible == true)
                    {
                        if (pacman2.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 10;
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "wall")
                    {
                        Rectangle pacmanHitBox = new Rectangle(pacman2.Left -1, pacman2.Top -1, pacman2.Width +1, pacman2.Height +1);
                        Rectangle wallHitBox = new Rectangle(x.Left, x.Top, x.Width, x.Height);
                        if (pacmanHitBox.IntersectsWith(wallHitBox))
                        {
                            if (left) directionBlock = "left";
                            if(right) directionBlock = "right";
                            if (up) directionBlock = "up";
                            if (down) directionBlock = "down";
                            playerSpeed = 0;
                        }
                        
                    }


                    if ((string)x.Tag == "ghost" && pacman2.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver();

                    }
                }
            }
            if((directionBlock== "left" && left) || (directionBlock == "right" && right)|| (directionBlock == "up" && up) || (directionBlock == "down" && down))
            {
                playerSpeed = 0;
            }
            else
            {
                playerSpeed = 10;
            }
        }
        private void keyPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;        
                
            }
            if(e.KeyCode == Keys.Space)
            {
                beginGame();
            }
        }



        private void PacMan_Load(object sender, EventArgs e)
        {

        }

        private void beginGame()
        {
                label1.Visible = false;
                resetGame();            
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            SoundPlayer sp = new SoundPlayer("waka.wav");
            sp.PlayLooping();
            Score.Text = "Score: " + score;
            score = 0;

            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhostSpeed = 5;
            pacman2.Left = 645;
            pacman2.Top = 541;
            isGameOver = false;
            pinkGhost.Left = 699;
            pinkGhost.Top = 187;
            redGhost.Left = 642;
            redGhost.Top = 187;
            yellowGhost.Left = 589;
            yellowGhost.Top = 187;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }
            timer1.Start();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
        private void gameWon()
        {
            label2.Text = "YOU WIN!!! GOOD JOB";
            label2.Visible = true;
            SoundPlayer sp = new SoundPlayer("win.wav");
            sp.Play();
            timer1.Stop();
        }

        private void gameOver()
        {
            label2.Text = "YOU LOST!!! YOUR SCORE: " + score;
            label2.Visible = true;
            SoundPlayer sp = new SoundPlayer("loose.wav");
            sp.Play();
            timer1.Stop();
        }

        public void chasePacman(Point pacmanPosition, ref Point ghostPosition, int ghostSpeed, int ghostWidth, int ghostHeight)
        {
            int dx = 0;
            int dy = 0;

            if (pacmanPosition.X < ghostPosition.X)
            {
                dx = -1;
            }
            else if (pacmanPosition.X > ghostPosition.X)
            {
                dx = 1;
            }

            if (pacmanPosition.Y < ghostPosition.Y)
            {
                dy = -1;
            }
            else if (pacmanPosition.Y > ghostPosition.Y)
            {
                dy = 1;
            }

            Rectangle ghostXRect = new Rectangle(ghostPosition.X + dx * ghostWidth, ghostPosition.Y, ghostWidth, ghostHeight);
            bool willCollideX = false;
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "wall" && ghostXRect.IntersectsWith(x.Bounds))
                {
                    willCollideX = true;
                    break;
                }
            }

            Rectangle ghostYRect = new Rectangle(ghostPosition.X, ghostPosition.Y + dy * ghostHeight, ghostWidth, ghostHeight);
            bool willCollideY = false;
            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "wall" && ghostYRect.IntersectsWith(x.Bounds))
                {
                    willCollideY = true;
                    break;
                }
            }

            if (!willCollideX)
            {
                ghostPosition.X += dx * ghostSpeed;
            }
            if (!willCollideY)
            {
                ghostPosition.Y += dy * ghostSpeed;
            }
        }


        private PictureBox pacman2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox30;
        private PictureBox pictureBox455;
        private Label label1;
        private Label label2;
    }


}