using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Flyweight
{
    class Font
    {
        private string key;

        public Font(string key)
        { 
        
        }
    }

    class FontFactory
    {
        private Dictionary<string, Font> fontPool = new Dictionary<string, Font>();

        /// <summary>
        /// 运用共享技术有效地支持大量细粒度的对象。
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Font GetFont(string key) 
        {
            if(fontPool.ContainsKey(key))
            {
                return fontPool[key];
            }
            else 
            { 
                Font font = new Font(key);
                fontPool.Add(key, font);
                return font; 
            }
        }

        public void Clear()
        {
            fontPool.Clear();
        }
    }
}
