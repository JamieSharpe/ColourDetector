using System;
using System.Collections.Generic;
using System.IO;

namespace ColourDetector
{
    class ColourData
    {
        List<KeyValuePair<string,string>> knownColours = new List<KeyValuePair<string, string>>();
        public ColourData()
        {
            if (!this.Load())
            {
                this.AddColours();
            }
        }

        /// <summary>
        /// Loads a file of known colours and imports them.
        /// </summary>
        /// <returns></returns>
        public bool Load()
        {
            try
            {
                using (FileStream fs = new FileStream("knownColours.xml", FileMode.Open))
                {
                    System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(List<KeyValuePair<string,string>>));
                    this.knownColours = (List<KeyValuePair<string,string>>)srl.Deserialize(fs);
                }
                if (this.knownColours.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Saves data from the application into a file.
        /// </summary>
        /// <returns><c>true</c> if the data was successfully saved.
        /// <c>false</c> otherwise.</returns>
        public bool Save()
        {
            try
            {
                using (FileStream fs = new FileStream("knownColours.xml", FileMode.Create))
                {
                    System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(List<KeyValuePair<string,string>>));
                    srl.Serialize(fs, this.knownColours);
                }
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        /// <summary>
        /// Adds a large list of colours.
        /// http://en.wikipedia.org/wiki/List_of_colors:_A%E2%80%93F
        /// http://en.wikipedia.org/wiki/List_of_colors:_G%E2%80%93M
        /// http://en.wikipedia.org/wiki/List_of_colors:_N%E2%80%93Z
        /// </summary>
        /// <remarks>
        /// This should only be called if there is a failure to load
        /// the file. This allows people to modify the file.
        /// </remarks>
        /// TODO: Add colours G-M + N-Z
        private void AddColours()
        {
            this.knownColours.Add(new KeyValuePair<string, string>("Acid Green", "#B0BF1A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Aero", "#7CB9E8"));
            this.knownColours.Add(new KeyValuePair<string, string>("Aero Blue", "#C9FFE5"));
            this.knownColours.Add(new KeyValuePair<string, string>("African Violet", "#B284BE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Air Force Blue (RAF)", "#5D8AA8"));
            this.knownColours.Add(new KeyValuePair<string, string>("Air Force Blue (USAF)", "#00308F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Air Superiority Blue", "#72A0C1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Alabama Crimson", "#AF002A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Alice Blue", "#F0F8FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Alizarin Crimson", "#E32636"));
            this.knownColours.Add(new KeyValuePair<string, string>("Alloy Orange", "#C46210"));
            this.knownColours.Add(new KeyValuePair<string, string>("Almond", "#EFDECD"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amaranth", "#E52B50"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amaranth Pink", "#F19CBB"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amaranth Purple", "#AB274F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amaranth Red", "#D3212D"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amazon", "#3B7A57"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amber", "#FFBF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amber (SAE/ECE)", "#FF7E00"));
            this.knownColours.Add(new KeyValuePair<string, string>("American Rose", "#FF033E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Amethyst", "#9966CC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Android Green", "#A4C639"));
            this.knownColours.Add(new KeyValuePair<string, string>("Anti-Flash White", "#F2F3F4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Antique Brass", "#CD9575"));
            this.knownColours.Add(new KeyValuePair<string, string>("Antique Bronze", "#665D1E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Antique Fuchsia", "#915C83"));
            this.knownColours.Add(new KeyValuePair<string, string>("Antique Ruby", "#841B2D"));
            this.knownColours.Add(new KeyValuePair<string, string>("Antique White", "#FAEBD7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Ao (English)", "#008000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Apple Green", "#8DB600"));
            this.knownColours.Add(new KeyValuePair<string, string>("Apricot", "#FBCEB1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Aqua", "#00FFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Aquamarine", "#7FFFD4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Army Green", "#4B5320"));
            this.knownColours.Add(new KeyValuePair<string, string>("Arsenic", "#3B444B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Artichoke", "#8F9779"));
            this.knownColours.Add(new KeyValuePair<string, string>("Arylide Yellow", "#E9D66B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Ash Grey", "#B2BEB5"));
            this.knownColours.Add(new KeyValuePair<string, string>("Asparagus", "#87A96B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Atomic Tangerine", "#FF9966"));
            this.knownColours.Add(new KeyValuePair<string, string>("Auburn", "#A52A2A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Aureolin", "#FDEE00"));
            this.knownColours.Add(new KeyValuePair<string, string>("AuroMetalSaurus", "#6E7F80"));
            this.knownColours.Add(new KeyValuePair<string, string>("Avocado", "#568203"));
            this.knownColours.Add(new KeyValuePair<string, string>("Azure", "#007FFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Azure (Web Color)", "#F0FFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Azure Mist", "#F0FFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Azureish White", "#DBE9F4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Baby Blue", "#89CFF0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Baby Blue Eyes", "#A1CAF1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Baby Pink", "#F4C2C2"));
            this.knownColours.Add(new KeyValuePair<string, string>("Baby Powder", "#FEFEFA"));
            this.knownColours.Add(new KeyValuePair<string, string>("Baker-Miller Pink", "#FF91AF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Ball Blue", "#21ABCD"));
            this.knownColours.Add(new KeyValuePair<string, string>("Banana Mania", "#FAE7B5"));
            this.knownColours.Add(new KeyValuePair<string, string>("Banana Yellow", "#FFE135"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bangladesh Green", "#006A4E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Barbie Pink", "#E0218A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Barn Red", "#7C0A02"));
            this.knownColours.Add(new KeyValuePair<string, string>("Battleship Grey", "#848482"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bazaar", "#98777B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Beau Blue", "#BCD4E6"));
            this.knownColours.Add(new KeyValuePair<string, string>("Beaver", "#9F8170"));
            this.knownColours.Add(new KeyValuePair<string, string>("Beige", "#F5F5DC"));
            this.knownColours.Add(new KeyValuePair<string, string>("B'dazzled Blue", "#2E5894"));
            this.knownColours.Add(new KeyValuePair<string, string>("Big Dip O’ruby", "#9C2542"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bisque", "#FFE4C4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bistre", "#3D2B1F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bistre Brown", "#967117"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bitter Lemon", "#CAE00D"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bitter Lime", "#BFFF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bittersweet", "#FE6F5E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bittersweet Shimmer", "#BF4F51"));
            this.knownColours.Add(new KeyValuePair<string, string>("Black", "#000000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Black Bean", "#3D0C02"));
            this.knownColours.Add(new KeyValuePair<string, string>("Black Leather Jacket", "#253529"));
            this.knownColours.Add(new KeyValuePair<string, string>("Black Olive", "#3B3C36"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blanched Almond", "#FFEBCD"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blast-Off Bronze", "#A57164"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bleu De France", "#318CE7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blizzard Blue", "#ACE5EE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blond", "#FAF0BE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue", "#0000FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue (Crayola)", "#1F75FE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue (Munsell)", "#0093AF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue (NCS)", "#0087BD"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue (Pantone)", "#0018A8"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue (Pigment)", "#333399"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue (RYB)", "#0247FE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue Bell", "#A2A2D0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue-Gray", "#6699CC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue-Green", "#0D98BA"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue-Magenta Violet", "#553592"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue Sapphire", "#126180"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue-Violet", "#8A2BE2"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blue Yonder", "#5072A7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blueberry", "#4F86F7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bluebonnet", "#1C1CF0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Blush", "#DE5D83"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bole", "#79443B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bondi Blue", "#0095B6"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bone", "#E3DAC9"));
            this.knownColours.Add(new KeyValuePair<string, string>("Boston University Red", "#CC0000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bottle Green", "#006A4E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Boysenberry", "#873260"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brandeis Blue", "#0070FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brass", "#B5A642"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brick Red", "#CB4154"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Cerulean", "#1DACD6"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Green", "#66FF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Lavender", "#BF94E4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Lilac", "#D891EF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Maroon", "#C32148"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Navy Blue", "#1974D2"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Pink", "#FF007F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Turquoise", "#08E8DE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bright Ube", "#D19FE8"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brilliant Azure", "#3399FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brilliant Lavender", "#F4BBFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brilliant Rose", "#FF55A3"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brink Pink", "#FB607F"));
            this.knownColours.Add(new KeyValuePair<string, string>("British Racing Green", "#004225"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bronze", "#CD7F32"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bronze Yellow", "#737000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brown (Traditional)", "#964B00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brown (Web)", "#A52A2A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brown-Nose", "#6B4423"));
            this.knownColours.Add(new KeyValuePair<string, string>("Brunswick Green", "#1B4D3E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bubble Gum", "#FFC1CC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bubbles", "#E7FEFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Buff", "#F0DC82"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bud Green", "#7BB661"));
            this.knownColours.Add(new KeyValuePair<string, string>("Bulgarian Rose", "#480607"));
            this.knownColours.Add(new KeyValuePair<string, string>("Burgundy", "#800020"));
            this.knownColours.Add(new KeyValuePair<string, string>("Burlywood", "#DEB887"));
            this.knownColours.Add(new KeyValuePair<string, string>("Burnt Orange", "#CC5500"));
            this.knownColours.Add(new KeyValuePair<string, string>("Burnt Sienna", "#E97451"));
            this.knownColours.Add(new KeyValuePair<string, string>("Burnt Umber", "#8A3324"));
            this.knownColours.Add(new KeyValuePair<string, string>("Byzantine", "#BD33A4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Byzantium", "#702963"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cadet", "#536872"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cadet Blue", "#5F9EA0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cadet Grey", "#91A3B0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cadmium Green", "#006B3C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cadmium Orange", "#ED872D"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cadmium Red", "#E30022"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cadmium Yellow", "#FFF600"));
            this.knownColours.Add(new KeyValuePair<string, string>("Café Au Lait", "#A67B5B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Café Noir", "#4B3621"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cal Poly Pomona Green", "#1E4D2B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cambridge Blue", "#A3C1AD"));
            this.knownColours.Add(new KeyValuePair<string, string>("Camel", "#C19A6B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cameo Pink", "#EFBBCC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Camouflage Green", "#78866B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Canary Yellow", "#FFEF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Candy Apple Red", "#FF0800"));
            this.knownColours.Add(new KeyValuePair<string, string>("Candy Pink", "#E4717A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Capri", "#00BFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Caput Mortuum", "#592720"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cardinal", "#C41E3A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Caribbean Green", "#00CC99"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carmine", "#960018"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carmine (M&P)", "#D70040"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carmine Pink", "#EB4C42"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carmine Red", "#FF0038"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carnation Pink", "#FFA6C9"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carnelian", "#B31B1B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carolina Blue", "#56A0D3"));
            this.knownColours.Add(new KeyValuePair<string, string>("Carrot Orange", "#ED9121"));
            this.knownColours.Add(new KeyValuePair<string, string>("Castleton Green", "#00563F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Catalina Blue", "#062A78"));
            this.knownColours.Add(new KeyValuePair<string, string>("Catawba", "#703642"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cedar Chest", "#C95A49"));
            this.knownColours.Add(new KeyValuePair<string, string>("Ceil", "#92A1CF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Celadon", "#ACE1AF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Celadon Blue", "#007BA7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Celadon Green", "#2F847C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Celeste", "#B2FFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Celestial Blue", "#4997D0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cerise", "#DE3163"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cerise Pink", "#EC3B83"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cerulean", "#007BA7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cerulean Blue", "#2A52BE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cerulean Frost", "#6D9BC3"));
            this.knownColours.Add(new KeyValuePair<string, string>("CG Blue", "#007AA5"));
            this.knownColours.Add(new KeyValuePair<string, string>("CG Red", "#E03C31"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chamoisee", "#A0785A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Champagne", "#F7E7CE"));
            this.knownColours.Add(new KeyValuePair<string, string>("Charcoal", "#36454F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Charleston Green", "#232B2B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Charm Pink", "#E68FAC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chartreuse (Traditional)", "#DFFF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chartreuse (Web)", "#7FFF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cherry", "#DE3163"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cherry Blossom Pink", "#FFB7C5"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chestnut", "#954535"));
            this.knownColours.Add(new KeyValuePair<string, string>("China Pink", "#DE6FA1"));
            this.knownColours.Add(new KeyValuePair<string, string>("China Rose", "#A8516E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chinese Red", "#AA381E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chinese Violet", "#856088"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chocolate (Traditional)", "#7B3F00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chocolate (Web)", "#D2691E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Chrome Yellow", "#FFA700"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cinereous", "#98817B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cinnabar", "#E34234"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cinnamon", "#D2691E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Citrine", "#E4D00A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Citron", "#9FA91F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Claret", "#7F1734"));
            this.knownColours.Add(new KeyValuePair<string, string>("Classic Rose", "#FBCCE7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cobalt", "#0047AB"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cocoa Brown", "#D2691E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Coconut", "#965A3E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Coffee", "#6F4E37"));
            this.knownColours.Add(new KeyValuePair<string, string>("Columbia Blue", "#C4D8E2"));
            this.knownColours.Add(new KeyValuePair<string, string>("Congo Pink", "#F88379"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cool Black", "#000000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cool Grey", "#8C92AC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Copper", "#B87333"));
            this.knownColours.Add(new KeyValuePair<string, string>("Copper (Crayola)", "#DA8A67"));
            this.knownColours.Add(new KeyValuePair<string, string>("Copper Penny", "#AD6F69"));
            this.knownColours.Add(new KeyValuePair<string, string>("Copper Red", "#CB6D51"));
            this.knownColours.Add(new KeyValuePair<string, string>("Copper Rose", "#996666"));
            this.knownColours.Add(new KeyValuePair<string, string>("Coquelicot", "#FF3800"));
            this.knownColours.Add(new KeyValuePair<string, string>("Coral", "#FF7F50"));
            this.knownColours.Add(new KeyValuePair<string, string>("Coral Pink", "#F88379"));
            this.knownColours.Add(new KeyValuePair<string, string>("Coral Red", "#FF4040"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cordovan", "#893F45"));
            this.knownColours.Add(new KeyValuePair<string, string>("Corn", "#FBEC5D"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cornell Red", "#B31B1B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cornflower Blue", "#6495ED"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cornsilk", "#FFF8DC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cosmic Latte", "#FFF8E7"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cotton Candy", "#FFBCD9"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cream", "#FFFDD0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Crimson", "#DC143C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Crimson Glory", "#BE0032"));
            this.knownColours.Add(new KeyValuePair<string, string>("Crimson Red", "#990000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cyan", "#00FFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cyan Azure", "#4E82b4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cyan Cobalt Blue", "#28589C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cyan Cornflower Blue", "#188BC2"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cyan (Process)", "#00B7EB"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cyber Grape", "#58427C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Cyber Yellow", "#FFD300"));
            this.knownColours.Add(new KeyValuePair<string, string>("Daffodil", "#FFFF31"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dandelion", "#F0E130"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Blue", "#00008B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Blue-Gray", "#666699"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Brown", "#654321"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Byzantium", "#5D3954"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Candy Apple Red", "#A40000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Cerulean", "#08457E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Chestnut", "#986960"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Coral", "#CD5B45"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Cyan", "#008B8B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Electric Blue", "#536878"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Goldenrod", "#B8860B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Gray (X11)", "#A9A9A9"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Green", "#013220"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Green (X11)", "#006400"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Imperial Blue", "#00416A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Jungle Green", "#1A2421"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Khaki", "#BDB76B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Lava", "#483C32"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Lavender", "#734F96"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Liver", "#534B4F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Liver (Horses)", "#543D37"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Magenta", "#8B008B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Medium Gray", "#A9A9A9"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Midnight Blue", "#003366"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Moss Green", "#4A5D23"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Olive Green", "#556B2F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Orange", "#FF8C00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Orchid", "#9932CC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Pastel Blue", "#779ECB"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Pastel Green", "#03C03C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Pastel Purple", "#966FD6"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Pastel Red", "#C23B22"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Pink", "#E75480"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Powder Blue", "#003399"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Puce", "#4F3A3C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Raspberry", "#872657"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Red", "#8B0000"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Salmon", "#E9967A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Scarlet", "#560319"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Sea Green", "#8FBC8F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Sienna", "#3C1414"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Sky Blue", "#8CBED6"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Slate Blue", "#483D8B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Slate Gray", "#2F4F4F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Spring Green", "#177245"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Tan", "#918151"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Tangerine", "#FFA812"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Taupe", "#483C32"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Terra Cotta", "#CC4E5C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Turquoise", "#00CED1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Vanilla", "#D1BEA8"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Violet", "#9400D3"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dark Yellow", "#9B870C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dartmouth Green", "#00703C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Davy's Grey", "#555555"));
            this.knownColours.Add(new KeyValuePair<string, string>("Debian Red", "#D70A53"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Carmine", "#A9203E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Carmine Pink", "#EF3038"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Carrot Orange", "#E9692C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Cerise", "#DA3287"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Champagne", "#FAD6A5"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Chestnut", "#B94E48"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Coffee", "#704241"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Fuchsia", "#C154C1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Green", "#056608"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Green-Cyan Turquoise", "#0E7C61"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Jungle Green", "#004B49"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Koamaru", "#333366"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Lemon", "#F5C71A"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Lilac", "#9955BB"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Magenta", "#CC00CC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Mauve", "#D473D4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Moss Green", "#355E3B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Peach", "#FFCBA4"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Pink", "#FF1493"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Puce", "#A95C68"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Ruby", "#843F5B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Saffron", "#FF9933"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Sky Blue", "#00BFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Space Sparkle", "#4A646C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Spring Bud", "#556B2F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Taupe", "#7E5E60"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deep Tuscan Red", "#66424D"));
            this.knownColours.Add(new KeyValuePair<string, string>("Deer", "#BA8759"));
            this.knownColours.Add(new KeyValuePair<string, string>("Denim", "#1560BD"));
            this.knownColours.Add(new KeyValuePair<string, string>("Desaturated Cyan", "#669999"));
            this.knownColours.Add(new KeyValuePair<string, string>("Desert", "#C19A6B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Desert Sand", "#EDC9AF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Desire", "#EA3C53"));
            this.knownColours.Add(new KeyValuePair<string, string>("Diamond", "#B9F2FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dim Gray", "#696969"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dirt", "#9B7653"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dodger Blue", "#1E90FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dogwood Rose", "#D71868"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dollar Bill", "#85BB65"));
            this.knownColours.Add(new KeyValuePair<string, string>("Donkey Brown", "#664C28"));
            this.knownColours.Add(new KeyValuePair<string, string>("Drab", "#967117"));
            this.knownColours.Add(new KeyValuePair<string, string>("Duke Blue", "#00009C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dust Storm", "#E5CCC9"));
            this.knownColours.Add(new KeyValuePair<string, string>("Dutch White", "#EFDFBB"));
            this.knownColours.Add(new KeyValuePair<string, string>("Earth Yellow", "#E1A95F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Ebony", "#555D50"));
            this.knownColours.Add(new KeyValuePair<string, string>("Ecru", "#C2B280"));
            this.knownColours.Add(new KeyValuePair<string, string>("Eerie Black", "#1B1B1B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Eggplant", "#614051"));
            this.knownColours.Add(new KeyValuePair<string, string>("Eggshell", "#F0EAD6"));
            this.knownColours.Add(new KeyValuePair<string, string>("Egyptian Blue", "#1034A6"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Blue", "#7DF9FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Crimson", "#FF003F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Cyan", "#00FFFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Green", "#00FF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Indigo", "#6F00FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Lavender", "#F4BBFF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Lime", "#CCFF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Purple", "#BF00FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Ultramarine", "#3F00FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Violet", "#8F00FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Electric Yellow", "#FFFF33"));
            this.knownColours.Add(new KeyValuePair<string, string>("Emerald", "#50C878"));
            this.knownColours.Add(new KeyValuePair<string, string>("Eminence", "#6C3082"));
            this.knownColours.Add(new KeyValuePair<string, string>("English Green", "#1B4D3E"));
            this.knownColours.Add(new KeyValuePair<string, string>("English Lavender", "#B48395"));
            this.knownColours.Add(new KeyValuePair<string, string>("English Red", "#AB4B52"));
            this.knownColours.Add(new KeyValuePair<string, string>("English Violet", "#563C5C"));
            this.knownColours.Add(new KeyValuePair<string, string>("Eton Blue", "#96C8A2"));
            this.knownColours.Add(new KeyValuePair<string, string>("Eucalyptus", "#44D7A8"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fallow", "#C19A6B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Falu Red", "#801818"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fandango", "#B53389"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fandango Pink", "#DE5285"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fashion Fuchsia", "#F400A1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fawn", "#E5AA70"));
            this.knownColours.Add(new KeyValuePair<string, string>("Feldgrau", "#4D5D53"));
            this.knownColours.Add(new KeyValuePair<string, string>("Feldspar", "#FDD5B1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fern Green", "#4F7942"));
            this.knownColours.Add(new KeyValuePair<string, string>("Ferrari Red", "#FF2800"));
            this.knownColours.Add(new KeyValuePair<string, string>("Field Drab", "#6C541E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Firebrick", "#B22222"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fire Engine Red", "#CE2029"));
            this.knownColours.Add(new KeyValuePair<string, string>("Flame", "#E25822"));
            this.knownColours.Add(new KeyValuePair<string, string>("Flamingo Pink", "#FC8EAC"));
            this.knownColours.Add(new KeyValuePair<string, string>("Flattery", "#6B4423"));
            this.knownColours.Add(new KeyValuePair<string, string>("Flavescent", "#F7E98E"));
            this.knownColours.Add(new KeyValuePair<string, string>("Flax", "#EEDC82"));
            this.knownColours.Add(new KeyValuePair<string, string>("Flirt", "#A2006D"));
            this.knownColours.Add(new KeyValuePair<string, string>("Floral White", "#FFFAF0"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fluorescent Orange", "#FFBF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fluorescent Pink", "#FF1493"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fluorescent Yellow", "#CCFF00"));
            this.knownColours.Add(new KeyValuePair<string, string>("Folly", "#FF004F"));
            this.knownColours.Add(new KeyValuePair<string, string>("Forest Green (Traditional)", "#014421"));
            this.knownColours.Add(new KeyValuePair<string, string>("Forest Green (Web)", "#228B22"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Beige", "#A67B5B"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Bistre", "#856D4D"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Blue", "#0072BB"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Fuchsia", "#FD3F92"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Lilac", "#86608E"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Lime", "#9EFD38"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Mauve", "#D473D4"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Pink", "#FD6C9E"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Plum", "#811453"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Puce", "#4E1609"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Raspberry", "#C72C48"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Rose", "#F64A8A"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Sky Blue", "#77B5FE"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Violet", "#8806CE"));
            this.knownColours.Add(new KeyValuePair<string, string>("French Wine", "#AC1E44"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fresh Air", "#A6E7FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fuchsia", "#FF00FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fuchsia (Crayola)", "#C154C1"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fuchsia Pink", "#FF77FF"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fuchsia Purple", "#CC397B"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fuchsia Rose", "#C74375"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fulvous", "#E48400"));
            this.knownColours.Add(new KeyValuePair<string, string>("Fuzzy Wuzzy", "#CC6666"));
        }
    }
}
