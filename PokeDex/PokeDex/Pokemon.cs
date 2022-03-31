using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PokeDex
{
    class Pokemon
    {
        string m_type;
        string m_move;
        string m_name;
        string m_desc;
        string m_pic;
        int m_weight;
        int m_height;
        int m_hp;
        
        

        public Pokemon(string type, string move, string desc, string pic, string name, int hp, int weight, int height)
        {
            m_type = type;
            m_move = move;
            m_name = name;
            m_desc = desc;
            m_pic = pic;
            m_hp = hp;
            m_weight = weight;
            m_height = height;
        }
        public Pokemon(string line)
        {
            if (line != null && line.Length > 0)
            {
                string[] field = line.Split(',');
                m_type = field[0];
                m_move = field[1];
                m_name = field[4];
                m_desc = field[2];
                m_pic = field[3];
                m_weight = int.Parse(field[6]);
                m_height = int.Parse(field[7]);
                m_hp = int.Parse(field[5]);
            }
        }

        public string getType() { return m_type; }      
        public void setType(string type) { m_type = type; }
        public string getMove() {return m_move;}
        public void setMove(string move){m_move = move; }
        public string getName(){return m_name;}
        public void setName(string name){m_name = name;}
        public string getDesc(){return m_desc;}
        public void setDesc(string desc){m_desc = desc;}
        public string getPic(){return m_pic;}
        public void setPic(string pic){m_pic = pic;}
        public int getWeight(){return m_weight;}
        public void setWeight(int weight){m_weight = weight;}
        public int getHeight(){return m_height;}
        public void setHeight(int height){m_height = height;}
        public int getHp(){return m_hp;}
        public void setHp(int hp){ m_hp = hp;}

        public void save()
        {
            

        }
    }
}
