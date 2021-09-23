# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""

from pyswip import Prolog
prolog=Prolog()
prolog.assertz("padrede(juan,maria)") #Juan es padre de Maria
prolog.assertz("padrede(pablo,juan)")
prolog.assertz("padrede(pablo,marcela)")
prolog.assertz("padrede(carlos,debora)")

prolog.assertz("hijode(maria,juan)")   #Maria es hija de Juan
prolog.assertz("hijode(juan,pablo)")
prolog.assertz("hijode(marcela,pablo)")
prolog.assertz("hijode(debora,carlos)")

prolog.assertz("abuelode(pablo,maria)")   #Pablo es abuelo de Maria

prolog.assertz("hermanode(juan,marcela)")   #Juan es hermano Marcela



#list(prolog.query("padrede(juan,X)"))==[{'X':'Y'}]
for elemento in prolog.query("padrede(X,Y)"):
    print(elemento["X"],"es el padre de", elemento["Y"])
for elemento in prolog.query("hijode(X,Y)"):
    print(elemento["X"],"es hijo de", elemento["Y"])
for elemento in prolog.query("abuelode(X,Y)"):
    print(elemento["X"],"es abuelo de", elemento["Y"])
for elemento in prolog.query("hermanode(X,Y)"):
    print(elemento["X"],"es hermano de", elemento["Y"])