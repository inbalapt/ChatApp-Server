using ServerApi.Models;

namespace ServerApp.Services
{
    public class UserService 
    {
        private static List<User> users = new List<User>()
        {
//////////////////////////////////////////////////////////////////////////////////////////////////
            new User(){Id = "inbal33" , Name = "Inbal", Server = "" , Password="123",

         
              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "yoval99", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                    new Chats()
                    {
                        Id = "noale10", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hello mis", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="what you wamt", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "harel21", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hihihihi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="whattttt", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "tomer50", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="good", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="day", Created="14/7", Sent=false}
                        }
                    },
                      new Chats()
                    {
                        Id = "yair39", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="nice", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="mazal tov", Created="14/7", Sent=false}
                        }
                     }

               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="yoval99", Name="Yoval", Last="you are so nice", LastDate="14/3", Server="" },
                  new Contacts(){Id="noale10", Name="noah", Last="what you wamt", LastDate="14/3", Server="" },
                  new Contacts(){Id="harel21", Name="Harel", Last="whattttt", LastDate="14/3", Server="" },
                  new Contacts(){Id="tomer50", Name="Tomer", Last="day", LastDate="14/3", Server="" },
                  new Contacts(){Id="yair39", Name="Yair", Last="mazal tov", LastDate="14/3", Server="" }
               }
            },
//////////////////////////////////////////////////////////////////////////////////////////////////
            new User(){Id = "harel21" , Name = "Harel", Server = "" , Password="123",

              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "yoval99", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="holahola", Created="14/7", Sent=false}
                        }
                    },
                    new Chats()
                    {
                        Id = "inbal33", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "yair39", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "tomer50", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                      new Chats()
                    {
                        Id = "michal321", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                     }

               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="yoval99", Name="Yoval", Last="holahola", LastDate="14/3", Server="" },
                  new Contacts(){Id="inbal33", Name="Inbal", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="yair39", Name="Yair", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="tomer50", Name="Tomer", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="michal321", Name="Michal", Last="how?", LastDate="14/3", Server="" }
               }
            },

//////////////////////////////////////////////////////////////////////////////////////////////////
            new User(){Id = "yoval99" , Name = "Yoval", Server = "" , Password="123",

              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "inbal33", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                    new Chats()
                    {
                        Id = "harel21", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "noale10", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "tomer50", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                      new Chats()
                    {
                        Id = "michal321", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                     }

               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="inbal33", Name="Inbal", Last="what?", LastDate="14/3", Server="" },
                  new Contacts(){Id="harel21", Name="Harel", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="noale10", Name="Noa", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="tomer50", Name="Tomer", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="michal321", Name="Michal", Last="how?", LastDate="14/3", Server="" }
               }
            },

//////////////////////////////////////////////////////////////////////////////////////////////////            
           new User(){Id = "noale10" , Name = "Noa", Server = "" , Password="123",

              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "inbal33", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                    new Chats()
                    {
                        Id = "yoval99", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "tomer50", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "yair39", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                      new Chats()
                    {
                        Id = "michal321", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                     }

               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="inbal33", Name="Inbal", Last="what?", LastDate="14/3", Server="" },
                  new Contacts(){Id="yoval99", Name="Yoval", Last="how?", LastDate="14/3", Server="" },                  
                  new Contacts(){Id="tomer50", Name="Tomer", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="yair39", Name="Yair", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="michal321", Name="Michal", Last="how?", LastDate="14/3", Server="" }
               }
            },

//////////////////////////////////////////////////////////////////////////////////////////////////
           new User(){Id = "tomer50" , Name = "Tomer", Server = "" , Password="123",

              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "inbal33", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                    
                     new Chats()
                    {
                        Id = "harel21", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },

                    new Chats()
                    {
                        Id = "yoval99", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "noale10", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                      new Chats()
                    {
                        Id = "yair39", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                     }

               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="inbal33", Name="Inbal", Last="what?", LastDate="14/3", Server="" },
                  new Contacts(){Id="harel21", Name="Harel", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="yoval99", Name="Yoval", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="noale10", Name="Noa", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="yair39", Name="Yair", Last="how?", LastDate="14/3", Server="" }
               }
            },

//////////////////////////////////////////////////////////////////////////////////////////////////
           new User(){Id = "yair39" , Name = "Yair", Server = "" , Password="123",

              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "inbal33", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },

                     new Chats()
                    {
                        Id = "harel21", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },

                    new Chats()
                    {
                        Id = "noale10", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "tomer50", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                      new Chats()
                    {
                        Id = "michal321", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                     }

               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="inbal33", Name="Inbal", Last="what?", LastDate="14/3", Server="" },
                  new Contacts(){Id="harel21", Name="Harel", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="noale10", Name="Noa", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="tomer50", Name="Tomer", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="michal321", Name="Michal", Last="how?", LastDate="14/3", Server="" }
               }
            },

//////////////////////////////////////////////////////////////////////////////////////////////////
           new User(){Id = "michal321" , Name = "Michal", Server = "" , Password="123",

              Chats=new List<Chats>{
                    new Chats()
                    {
                        Id = "inbal33", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },

                     new Chats()
                    {
                        Id = "harel21", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },

                    new Chats()
                    {
                        Id = "yoval99", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                     new Chats()
                    {
                        Id = "yair39", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                    },
                      new Chats()
                    {
                        Id = "noale10", Messages=new List<Messages>()
                        {
                            new Messages(){
                                Id=1, Content="hi", Created="14/7", Sent=true},
                             new Messages(){
                                Id=2, Content="how?", Created="14/7", Sent=false}
                        }
                     }

               },
              Contacts = new List<Contacts>()
              {
                  new Contacts(){Id="inbal33", Name="Inbal", Last="what?", LastDate="14/3", Server="" },
                  new Contacts(){Id="harel21", Name="Harel", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="yoval99", Name="Yoval", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="yair39", Name="Yair", Last="how?", LastDate="14/3", Server="" },
                  new Contacts(){Id="noale10", Name="Noa", Last="how?", LastDate="14/3", Server="" }
               }
            }

        };

       
/*
        private Dictionary<string, List<User>> _usersDict = new Dictionary<string, List<User>>()
        { {"inbal33", new List<User>()
        { new User(){Id = "noale10" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "yoval99" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "harel21" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}},

        {"harel21", new List<User>()
        { new User(){Id = "inbal33" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "yoval99" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "yair39" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}},


        {"yoval99", new List<User>()
        { new User(){Id = "inbal33" , Name = "Noa", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "harel21" , Name = "yoval", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "noale10" , Name = "harel", Server = "" , last = "" , lastdate = "" },
          new User(){Id = "tomer50" , Name = "tomer", Server = "" , last = "" , lastdate = "" }}}

        };*/
        public List<User> GetAll()
        {
            return users;
        }

        public List<Contacts> GetContacts(string connected)
        {
            foreach (var user in users)
            {
                if (user.Id == connected)
                {
                    return user.Contacts;
                }
            }
            return null;
        }
        public string RetPassword(string connected)
        {
            foreach (var user in users)
            {
                if (user.Id == connected)
                {
                    return user.Password;
                }
            }
            return null;
        }
        public string RetName(string connected)
        {
            foreach (var user in users)
            {
                if (user.Id == connected)
                {
                    return user.Name;
                }
            }
            return null;
        }

        public List<Chats> GetMessages(string connected)
        {
            foreach (var user in users)
            {
                if (user.Id == connected)
                {
                    return user.Chats;
                }
            }
            return null;
        }

        //public string connected = "inbal";
    }
}
