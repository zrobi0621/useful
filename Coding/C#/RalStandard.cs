using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RalStandard
{
    public struct RGB
    {
        public int r;
        public int g;
        public int b;
    }

    public struct RAL
    {
        public string RALCode;
        public RGB RGB;
        public string HEX;
        public string German;
        public string English;
        public string French;
        public string Spanish;
        public string Italian;
        public string Nederlands;
    }

    public static string RALStandardCodes = @"RAL, RGB, HEX, German, English, French, Spanish, Italian, Nederlands
RAL 1000,190-189-127,#BEBD7F,Gr�nbeige,Green beige,Beige vert,Beige verdoso,Beige verdastro,Groenbeige
RAL 1001,194-176-120,#C2B078,Beige,Beige,Beige,Beige,Beige,Beige
RAL 1002,198-166-100,#C6A664,Sandgelb,Sand yellow,Jaune sable,Amarillo arena,Giallo sabbia,Zandgeel
RAL 1003,229-190-001,#E5BE01,Signalgelb,Signal yellow,Jaune de s�curit�,Amarillo se�ales,Giallo segnale,Signaalgeel
RAL 1004,205-164-052,#CDA434,Goldgelb,Golden yellow,Jaune or,Amarillo oro,Giallo oro,Goudgeel
RAL 1005,169-131-007,#A98307,Honiggelb,Honey yellow,Jaune miel,Amarillo miel,Giallo miele,Honinggeel
RAL 1006,228-160-016,#E4A010,Maisgelb,Maize yellow,Jaune ma�s,Amarillo maiz,Giallo polenta,Maisgeel
RAL 1007,220-156-000,#DC9D00,Narzissengelb,Daffodil yellow,Jaune narcisse,Amarillo narciso,Giallo narciso,Narcissengeel
RAL 1011,138-102-066,#8A6642,Braunbeige,Brown beige,Beige brun,Beige pardo,Beige marrone,Bruinbeige
RAL 1012,199-180-070,#C7B446,Zitronengelb,Lemon yellow,Jaune citron,Amarillo lim�n,Giallo limone,Citroengeel
RAL 1013,234-230-202,#EAE6CA,Perlwei�,Oyster white,Blanc perl�,Blanco perla,Bianco perla,Parelwit
RAL 1014,225-204-079,#E1CC4F,Elfenbein,Ivory,Ivoire,Marfil,Avorio,Ivoorkleurig
RAL 1015,230-214-144,#E6D690,Hellelfenbein,Light ivory,Ivoire clair,Marfil claro,Avorio chiaro,Licht ivoorkleurig
RAL 1016,237-255-033,#EDFF21,Schwefelgelb,Sulfur yellow,Jaune soufre,Amarillo azufre,Giallo zolfo,Zwavelgeel
RAL 1017,245-208-051,#F5D033,Safrangelb,Saffron yellow,Jaune safran,Amarillo azafr�n,Giallo zafferano,Saffraangeel
RAL 1018,248-243-053,#F8F32B,Zinkgelb,Zinc yellow,Jaune zinc,Amarillo de zinc,Giallo zinco,Zinkgeel
RAL 1019,158-151-100,#9E9764,Graubeige,Grey beige,Beige gris,Beige agrisado,Beige grigiastro,Grijsbeige
RAL 1020,153-153-080,#999950,Olivgelb,Olive yellow,Jaune olive,Amarillo oliva,Giallo olivastro,Olijfgeel
RAL 1021,243-218-011,#F3DA0B,Rapsgelb,Rape yellow,Jaune colza,Amarillo colza,Giallo navone,Koolzaadgeel
RAL 1023,250-210-001,#FAD201,Verkehrsgelb,Traffic yellow,Jaune signalisation,Amarillo tr�fico,Giallo traffico,Verkeersgeel
RAL 1024,174-160-075,#AEA04B,Ockergelb,Ochre yellow,Jaune ocre,Amarillo ocre,Giallo ocra,Okergeel
RAL 1026,255-255-000,#FFFF00,Leuchtgelb,Luminous yellow,Jaune brillant,Amarillo brillante,Giallo brillante,Briljantgeel
RAL 1027,157-145-001,#9D9101,Currygelb,Curry,Jaune curry,Amarillo curry,Giallo curry,Kerriegeel
RAL 1028,244-169-000,#F4A900,Melonengelb,Melon yellow,Jaune melon,Amarillo mel�n,Giallo melone,Meloengeel
RAL 1032,214-174-001,#D6AE01,Ginstergelb,Broom yellow,Jaune gen�t,Amarillo retama,Giallo scopa,Bremgeel
RAL 1033,243-165-005,#F3A505,Dahliengelb,Dahlia yellow,Jaune dahlia,Amarillo dalia,Giallo dahlien,Dahliageel
RAL 1034,239-169-074,#EFA94A,Pastellgelb,Pastel yellow,Jaune pastel,Amarillo pastel,Giallo pastello,Pastelgeel
RAL 1035,106-093-077,#6A5D4D,Perlbeige,Pearl beige,Beige nacr�,Beige perlado,Beige perlato,Parelmoergrijs
RAL 1036,112-083-053,#705335,Perlgold,Pearl gold,Or nacr�,Oro perlado,Oro perlato,Parelmoergoud
RAL 1037,243-159-024,#F39F18,Sonnengelb,Sun yellow,Jaune soleil,Amarillo sol,Giallo sole,Zonnegeel
RAL 2000,237-118-014,#ED760E,Gelborange,Yellow orange,Orang� jaune,Amarillo naranja,Arancio giallastro,Geeloranje
RAL 2001,201-060-032,#C93C20,Rotorange,Red orange,Orang� rouge,Rojo anaranjado,Arancio rossastro,Roodoranje
RAL 2002,203-040-033,#CB2821,Blutorange,Vermilion,Orang� sang,Naranja sanguineo,Arancio sanguigno,Vermiljoen
RAL 2003,255-117-020,#FF7514,Pastellorange,Pastel orange,Orang� pastel,Naranja p�lido,Arancio pastello,Pasteloranje
RAL 2004,244-070-017,#F44611,Reinorange,Pure orange,Orang� pur,Naranja puro,Arancio puro,Zuiver oranje
RAL 2005,255-035-001,#FF2301,Leuchtorange,Luminous orange,Orang� brillant,Naranja brillante,Arancio brillante,Briljant oranje
RAL 2007,255-164-032,#FFA420,Leuchthellorange,Luminous bright orange,Orang� clair rillant,Naranja claro brillante,Arancio chiaro brillante,Briljant lichtoranje
RAL 2008,247-094-037,#F75E25,Hellrotorange,Bright red orange,Orang� rouge clair,Rojo claro anaranjado,Rosso arancio chiaro,Licht roodoranje
RAL 2009,245-064-033,#F54021,Verkehrsorange,Traffic orange,Orang� signalisation,Naranja tr�fico,Arancio traffico,Verkeersoranje
RAL 2010,216-075-032,#D84B20,Signalorange,Signal orange,Orang� de s�curit�,Naranja se�ales,Arancio segnale,Signaaloranje
RAL 2011,236-124-038,#EC7C26,Tieforange,Deep orange,Orang� fonc�,Naranja intenso,Arancio profondo,Dieporanje
RAL 2012,235-106-014,#E55137,Lachsorange,Salmon range,Orang� saumon,Naranja salm�n,Arancio salmone,Zalmoranje
RAL 2013,195-088-049,#C35831,Perlorange,Pearl orange,Orang� nacr�,Naranja perlado,Arancio perlato,Parelmoeroranje
RAL 3000,175-043-030,#AF2B1E,Feuerrot,Flame red,Rouge feu,Rojo vivo,Rosso fuoco,Vuurrood
RAL 3001,165-032-025,#A52019,Signalrot,Signal red,Rouge de s�curit�,Rojo se�ales,Rosso  segnale,Signaalrood
RAL 3002,162-035-029,#A2231D,Karminrot,Carmine red,Rouge carmin,Rojo carmin,Rosso carminio,Karmijnrood
RAL 3003,155-017-030,#9B111E,Rubinrot,Ruby red,Rouge rubis,Rojo rub�,Rosso rubino,Robijnrood
RAL 3004,117-021-030,#75151E,Purpurrot,Purple red,Rouge pourpre,Rojo purpura,Rosso porpora,Purperrood
RAL 3005,094-033-041,#5E2129,Weinrot,Wine red,Rouge vin,Rojo vino,Rosso vino,Wijnrood
RAL 3007,065-034-039,#412227,Schwarzrot,Black red,Rouge noir,Rojo negruzco,Rosso nerastro,Zwartrood
RAL 3009,100-036-036,#642424,Oxidrot,Oxide red,Rouge oxyde,Rojo �xido,Rosso  ossido,Oxyderood
RAL 3011,120-031-025,#781F19,Braunrot,Brown red,Rouge brun,Rojo pardo,Rosso marrone,Bruinrood
RAL 3012,193-135-107,#C1876B,Beigerot,Beige red,Rouge beige,Rojo beige,Rosso beige,Beigerood
RAL 3013,161-035-018,#A12312,Tomatenrot,Tomato red,Rouge tomate,Rojo tomate,Rosso pomodoro,Tomaatrood
RAL 3014,211-110-112,#D36E70,Altrosa,Antique pink,Vieux rose,Rojo viejo,Rosa antico,Oudroze
RAL 3015,234-137-154,#EA899A,Hellrosa,Light pink,Rose clair,Rosa claro,Rosa chiaro,Lichtroze
RAL 3016,179-040-033,#B32821,Korallenrot,Coral red,Rouge corail,Rojo coral,Rosso corallo,Koraalrood
RAL 3017,230-050-068,#E63244,Ros�,Rose,Ros�,Rosa,Rosato,Bleekrood
RAL 3018,213-048-050,#D53032,Erdbeerrot,Strawberry red,Rouge fraise,Rojo fresa,Rosso fragola,Aardbeirood
RAL 3020,204-006-005,#CC0605,Verkehrsrot,Traffic red,Rouge signalisation,Rojo tr�fico,Rosso traffico,Verkeersrood
RAL 3022,217-080-048,#D95030,Lachsrot,Salmon pink,Rouge saumon,Rojo salm�n,Rosso salmone,Zalmrood
RAL 3024,248-000-000,#F80000,Leuchtrot,Luminous red,Rouge brillant,Rojo brillante,Rosso brillante,Briljantrood
RAL 3026,254-000-000,#FE0000,Leuchthellrot,""Luminous bright red"",Rouge clair brillant,Rojo claro brillante,Rosso chiaro brillante,Briljant lichtrood
RAL 3027,197-029-052,#C51D34,Himbeerrot,Raspberry red,Rouge framboise,Rojo frambuesa,Rosso lampone,Framboosrood
RAL 3028,203-050-052,#CB3234,Reinrot,Pure  red,Rouge puro,Rojo puro,Rosso puro,Zuiverrood
RAL 3031,179-036-040,#B32428,Orientrot,Orient red,Rouge oriental,Rojo oriente,Rosso oriente,Ori�ntrood
RAL 3032,114-020-034,#721422,Perlrubinrot,Pearl ruby red,Rouge rubis nacr�,Rojo rub� perlado,Rosso rubino perlato,""Parelmoer-donkerrood""
RAL 3033,180-076-067,#B44C43,Perlrosa,Pearl pink,Rose nacr�,Rosa perlado,Rosa perlato,""Parelmoer-lichtrood""
RAL 4001,109-063-091,#6D3F5B,Rotlila,Red lilac,Lilas rouge,Rojo lila,Lilla rossastro,Roodlila
RAL 4002,146-043-062,#922B3E,Rotviolett,Red violet,Violet rouge,Rojo violeta,Viola rossastro,Roodpaars
RAL 4003,222-076-138,#DE4C8A,Erikaviolett,Heather violet,Violet bruy�re,Violeta �rica,Viola erica,Heidepaars
RAL 4004,110-028-052,#641C34,Bordeauxviolett,Claret violet,Violet bordeaux,Burdeos,Viola bordeaux,Bordeauxpaars
RAL 4005,108-070-117,#6C4675,Blaulila,Blue lilac,Lilas bleu,Lila azulado,Lilla bluastro,Blauwlila
RAL 4006,160-052-114,#A03472,Verkehrspurpur,Traffic purple,Pourpre signalisation,P�rpur� tr�fico,Porpora traffico,Verkeerspurper
RAL 4007,074-025-044,#4A192C,Purpurviolett,Purple violet,Violet pourpre,Violeta p�rpura,Porpora violetto,Purperviolet
RAL 4008,144-070-132,#924E7D,Signalviolett,Signal violet,Violet de s�curit�,Violeta se�ales,Violetto segnale,Signaalviolet
RAL 4009,164-125-144,#A18594,Pastellviolett,Pastel violet,Violet pastel,Violeta pastel,Violetto pastello,Pastelviolet
RAL 4010,215-045-109,#CF3476,Telemagenta,Telemagenta,Telemagenta,Magenta tele,Tele Magenta,Telemagenta
RAL 4011,134-115-161,#8673A1,Perlviolett,Pearl violet,Violet nacr�,Violeta perlado,Violetto perlato,""Parelmoer-donkerviolet""
RAL 4012,108-104-129,#6C6874,Perlbrombeer,Pearl black berry,M�re nacr�,Morado perlado,Mora perlato,""Parelmoer-lichtviolet""
RAL 5000,042-046-075,#354D73,Violettblau,Violet blue,Bleu violet,Azul violeta,Blu violaceo,Paarsblauw
RAL 5001,031-052-056,#1F3438,Gr�nblau,Green blue,Bleu vert,Azul verdoso,Blu verdastro,Groenblauw
RAL 5002,032-033-079,#20214F,Ultramarinblau,Ultramarine blue,Bleu outremer,Azul ultramar,Blu oltremare,Ultramarijnblauw
RAL 5003,029-030-051,#1D1E33,Saphirblau,Saphire blue,Bleu saphir,Azul zafiro,Blu zaffiro,Saffierblauw
RAL 5004,024-023-028,#18171C,Schwarzblau,Black blue,Bleu noir,Azul negruzco,Blu nerastro,Zwartblauw
RAL 5005,030-045-110,#1E2460,Signalblau,Signal blue,Bleu de s�curit�,Azul se�ales,Blu segnale,Signaalblauw
RAL 5007,062-095-138,#3E5F8A,Brillantblau,Brillant blue,Bleu brillant,Azul brillante,Blu brillante,Briljantblauw
RAL 5008,038-037-045,#26252D,Graublau,Grey blue,Bleu gris,Azul gris�ceo,Blu grigiastro,Grijsblauw
RAL 5009,002-086-105,#025669,Azurblau,Azure blue,Bleu azur,Azul azur,Blu  azzurro,Azuurblauw
RAL 5010,014-041-075,#0E294B,Enzianblau,Gentian blue,Bleu gentiane,Azul genciana,Blu  genziana,Gentiaanblauw
RAL 5011,035-026-036,#231A24,Stahlblau,Steel blue,Bleu acier,Azul acero,Blu acciaio,Staalblauw
RAL 5012,059-131-189,#3B83BD,Lichtblau,Light blue,Bleu clair,Azul luminoso,Blu luce,Lichtblauw
RAL 5013,037-041-074,#1E213D,Kobaltblau,Cobalt blue,Bleu cobalt,Azul cobalto,Blu cobalto,Kobaltblauw
RAL 5014,096-111-140,#606E8C,Taubenblau,Pigeon blue,Bleu pigeon,Azul olombino,Blu colomba,Duifblauw
RAL 5015,034-113-179,#2271B3,Himmelblau,Sky blue,Bleu ciel,Azul celeste,Blu cielo,Hemelsblauw
RAL 5017,006-057-113,#063971,Verkehrsblau,Traffic blue,Bleu signalisation,Azul tr�fico,Blu traffico,Verkeersblauw
RAL 5018,063-136-143,#3F888F,T�rkisblau,Turquoise blue,Bleu turquoise,Azul turquesa,Blu turchese,Turkooisblauw
RAL 5019,027-085-131,#1B5583,Capriblau,Capri blue,Bleu capri,Azul capri,Blu capri,Capriblauw
RAL 5020,029-051-074,#1D334A,Ozeanblau,Ocean blue,Bleu oc�an,Azul oceano,Blu oceano,Oceaanblauw
RAL 5021,037-109-123,#256D7B,Wasserblau,Water blue,Bleu d�eau,Azul agua,Blu acqua,Waterblauw
RAL 5022,037-040-080,#252850,Nachtblau,Night blue,Bleu nocturne,Azul noche,Blu notte,Nachtblauw
RAL 5023,073-103-141,#49678D,Fernblau,Distant blue,Bleu distant,Azul lejan�a,Blu distante,Verblauw
RAL 5024,093-155-155,#5D9B9B,Pastellblau,Pastel blue,Bleu pastel,Azul pastel,Blu pastello,Pastelblauw
RAL 5025,042-100-120,#2A6478,Perlenzian,Pearl gentian blue,Gentiane nacr�,Gencian perlado,Blu genziana perlato,Parelmoerblauw
RAL 5026,016-044-084,#102C54,Perlnachtblau,Pearl night blue,Bleu nuit nacr�,Azul noche perlado,Blu notte perlato,""Parelmoer-nachtblauw""
RAL 6000,049-102-080,#316650,Patinagr�n,Patina green,Vert patine,Verde patina,Verde patina,Patinagroen
RAL 6001,040-114-051,#287233,Smaragdgr�n,Emerald green,Vert �meraude,Verde esmeralda,Verde smeraldo,Smaragdgroen
RAL 6002,045-087-044,#2D572C,Laubgr�n,Leaf green,Vert feuillage,Verde hoja,Verde foglia,Loofgroen
RAL 6003,066-070-050,#424632,Olivgr�n,Olive green,Vert olive,Verde oliva,Verde oliva,Olijfgroen
RAL 6004,031-058-061,#1F3A3D,Blaugr�n,Blue green,Vert bleu,Verde azulado,Verde bluastro,Blauwgroen
RAL 6005,047-069-056,#2F4538,Moosgr�n,Moss green,Vert mousse,Verde musgo,Verde muschio,Mosgroen
RAL 6006,062-059-050,#3E3B32,Grauoliv,Grey olive,Olive gris,Oliva gris�ceo,Oliva grigiastro,Grijs olijfgroen
RAL 6007,052-059-041,#343B29,Flaschengr�n,Bottle green,Vert bouteille,Verde botella,Verde bottiglia,Flessegroen
RAL 6008,057-053-042,#39352A,Braungr�n,Brown green,Vert brun,Verde parduzco,Verde brunastro,Bruingroen
RAL 6009,049-055-043,#31372B,Tannengr�n,Fir green,Vert sapin,Verde abeto,Verde abete,Dennegroen
RAL 6010,053-104-045,#35682D,Grasgr�n,Grass green,Vert herbe,Verde hierba,Verde erba,Grasgroen
RAL 6011,088-114-070,#587246,Resedagr�n,Reseda green,Vert r�s�da,Verde reseda,Verde reseda,Resedagroen
RAL 6012,052-062-064,#343E40,Schwarzgr�n,Black green,Vert noir,Verde negruzco,Verde nerastro,Zwartgroen
RAL 6013,108-113-086,#6C7156,Schilfgr�n,Reed green,Vert jonc,Verde ca�a,Verde canna,Rietgroen
RAL 6014,071-064-046,#47402E,Gelboliv,Yellow olive,Olive jaune,Amarillo oliva,Oliva giallastro,Geel olijfgroen
RAL 6015,059-060-054,#3B3C36,Schwarzoliv,Black olive,Olive noir,Oliva negruzco,Oliva nerastro,Zwart olijfgroen
RAL 6016,030-089-069,#1E5945,T�rkisgr�n,Turquoise green,Vert turquoise,Verde turquesa,Verde turchese,Turkooisgroen
RAL 6017,076-145-065,#4C9141,Maigr�n,May green,Vert mai,Verde mayo,Verde maggio,Meigroen
RAL 6018,087-166-057,#57A639,Gelbgr�n,Yellow green,Vert jaune,Verde amarillento,Verde giallastro,Geelgroen
RAL 6019,189-236-182,#BDECB6,Wei�gr�n,Pastel green,Vert blanc,Verde lanquecino,Verde biancastro,Witgroen
RAL 6020,046-058-035,#2E3A23,Chromoxidgr�n,Chrome green,Vert oxyde chromique,Verde cromo,Verde cromo,""Chroom-oxydegroen""
RAL 6021,137-172-118,#89AC76,Blassgr�n,Pale green,Vert p�le,Verde p�lido,Verde pallido,Bleekgroen
RAL 6022,037-034-027,#25221B,Braunoliv,Olive drab,Olive brun,Oliva parduzco,Oliva brunastro,Bruin olijfgroen
RAL 6024,048-132-070,#308446,Verkehrsgr�n,Traffic green,Vert signalisation,Verde tr�fico,Verde traffico,Verkeersgroen
RAL 6025,061-100-045,#3D642D,Farngr�n,Fern green,Vert foug�re,Verde helecho,Verde felce,Varengroen
RAL 6026,001-093-082,#015D52,Opalgr�n,Opal green,Vert opale,Verde opalo,Verde opale,Opaalgroen
RAL 6027,132-195-190,#84C3BE,Lichtgr�n,Light green,Vert clair,Verde luminoso,Verde chiaro,Lichtgroen
RAL 6028,044-085-069,#2C5545,Kieferngr�n,Pine green,Vert pin,Verde pino,Verde pino,Pijnboomgroen
RAL 6029,032-096-061,#20603D,Minzgr�n,Mint green,Vert menthe,Verde menta,Verde menta,Mintgroen
RAL 6032,049-127-067,#317F43,Signalgr�n,Signal green,Vert de s�curit�,Verde se�ales,Verde segnale,Signaalgroen
RAL 6033,073-126-118,#497E76,Mintt�rkis,Mint turquoise,Turquoise menthe,Turquesa menta,Turchese menta,Mintturquoise
RAL 6034,127-181-181,#7FB5B5,Pastellt�rkis,Pastel turquoise,Turquoise pastel,Turquesa pastel,Turchese pastello,Pastelturquoise
RAL 6035,028-084-045,#1C542D,Perlgr�n,Pearl green,Vert nacr�,Verde perlado,Verde perlato,""Parelmoer-donkergroen""
RAL 6036,022-053-055,#193737,Perlopalgr�n,Pearl opal green,Vert opal nacr�,Verde �palo perlado,Verde opalo perlato,""Parelmoer-lichtgroen""
RAL 6037,000-143-057,#008F39,Reingr�n,Pure green,Vert pur,Verde puro,Verde puro,Zuivergroen
RAL 6038,000-187-045,#00BB2D,Leuchtgr�n,Luminous green,Vert brillant,Verde brillante,Verde brillante,Briljantgroen
RAL 7000,120-133-139,#78858B,Fehgrau,Squirrel grey,Gris petit-gris,Gris ardilla,Grigio vaio,Pelsgrijs
RAL 7001,138-149-151,#8A9597,Silbergrau,Silver grey,Gris argent,Gris plata,Grigio argento,Zilvergrijs
RAL 7002,126-123-082,#7E7B52,Olivgrau,Olive grey,Gris olive,Gris oliva,Grigio olivastro,Olijfgrijs
RAL 7003,108-112-089,#6C7059,Moosgrau,Moss grey,Gris mousse,Gris musgo,Grigio muschio,Mosgrijs
RAL 7004,150-153-146,#969992,Signalgrau,Signal grey,Gris de s�curit�,Gris se�ales,Grigio segnale,Signaalgrijs
RAL 7005,100-107-099,#646B63,Mausgrau,Mouse grey,Gris souris,Gris rat�n,Grigio topo,Muisgrijs
RAL 7006,109-101-082,#6D6552,Beigegrau,Beige grey,Gris beige,Gris beige,Grigio beige,Beigegrijs
RAL 7008,106-095-049,#6A5F31,Khakigrau,Khaki grey,Gris kaki,Gris caqui,Grigio kaki,Kakigrijs
RAL 7009,077-086-069,#4D5645,Gr�ngrau,Green grey,Gris vert,Gris verdoso,Grigio verdastro,Groengrijs
RAL 7010,076-081-074,#4C514A,Zeltgrau,Tarpaulin grey,Gris tente,Gris lona,Grigio tenda,Zeildoekgrijs
RAL 7011,067-075-077,#434B4D,Eisengrau,Iron grey,Gris fer,Gris hierro,Grigio ferro,IJzergrijs
RAL 7012,078-087-084,#4E5754,Basaltgrau,Basalt grey,Gris basalte,Gris basalto,Grigio basalto,Bazaltgrijs
RAL 7013,070-069-049,#464531,Braungrau,Brown grey,Gris brun,Gris parduzco,Grigio brunastro,Bruingrijs
RAL 7015,067-071-080,#434750,Schiefergrau,Slate grey,Gris ardoise,Gris pizarra,Grigio ardesia,Leigrijs
RAL 7016,041-049-051,#293133,Anthrazitgrau,Anthracite grey,Gris anthracite,Gris antracita,Grigio antracite,Antracietgrijs
RAL 7021,035-040-043,#23282B,Schwarzgrau,Black grey,Gris noir,Gris negruzco,Grigio nerastro,Zwartgrijs
RAL 7022,051-047-044,#332F2C,Umbragrau,Umbra grey,Gris terre d�ombre,Gris sombra,Grigio ombra,Ombergrijs
RAL 7023,104-108-094,#686C5E,Betongrau,Concrete grey,Gris b�ton,Gris hormig�n,Grigio calcestruzzo,Betongrijs
RAL 7024,071-074-081,#474A51,Graphitgrau,Graphite grey,Gris graphite,Gris grafita,Grigio grafite,Grafietgrijs
RAL 7026,047-053-059,#2F353B,Granitgrau,Granite grey,Gris granit,Gris granito,Grigio granito,Granietgrijs
RAL 7030,139-140-122,#8B8C7A,Steingrau,Stone grey,Gris pierre,Gris piedra,Grigio pietra,Steengrijs
RAL 7031,071-075-078,#474B4E,Blaugrau,Blue grey,Gris bleu,Gris azulado,Grigio bluastro,Blauwgrijs
RAL 7032,184-183-153,#B8B799,Kieselgrau,Pebble grey,Gris silex,Gris guijarro,Grigio ghiaia,Kiezelgrijs
RAL 7033,125-132-113,#7D8471,Zementgrau,Cement grey,Gris ciment,Gris cemento,Grigio cemento,Cementgrijs
RAL 7034,143-139-102,#8F8B66,Gelbgrau,Yellow grey,Gris jaune,Gris amarillento,Grigio giallastro,Geelgrijs
RAL 7035,203-208-204,#CBD0CC,Lichtgrau,Light grey,Gris clair,Gris luminoso,Grigio luce,Lichtgrijs
RAL 7036,127-118-121,#7F7679,Platingrau,Platinum grey,Gris platine,Gris platino,Grigio platino,Platinagrijs
RAL 7037,125-127-120,#7D7F7D,Staubgrau,Dusty grey,Gris poussi�re,Gris polvo,Grigio polvere,Stofgrijs
RAL 7038,195-195-195,#B5B8B1,Achatgrau,Agate grey,Gris agate,Gris �gata,Grigio agata,Agaatgrijs
RAL 7039,108-105-096,#6C6960,Quarzgrau,Quartz grey,Gris quartz,Gris cuarzo,Grigio quarzo,Kwartsgrijs
RAL 7040,157-161-170,#9DA1AA,Fenstergrau,Window grey,Gris fen�tre,Gris ventana,Grigio finestra,Venstergrijs
RAL 7042,141-148-141,#8D948D,Verkehrsgrau A,Traffic grey A,Gris signalisation A,Gris tr�fico A,Grigio traffico A,Verkeesgrijs A
RAL 7043,078-084-082,#4E5452,Verkehrsgrau B,Traffic grey B,Gris signalisation B,Gris tr�fico B,Grigio traffico B,Verkeersgrijs B
RAL 7044,202-196-176,#CAC4B0,Seidengrau,Silk grey,Gris soie,Gris seda,Grigio seta,Zijdegrijs
RAL 7045,144-144-144,#909090,Telegrau 1,Telegrey 1,Telegris 1,Gris tele 1,Tele grigio 1,Telegrijs 1
RAL 7046,130-137-143,#82898F,Telegrau 2,Telegrey 2,Telegris 2,Gris tele 2,Tele grigio 2,Telegrijs 2
RAL 7047,208-208-208,#D0D0D0,Telegrau 4,Telegrey 4,Telegris 4,Gris tele 4,Tele grigio 4,Telegrijs 4
RAL 7048,137-129-118,#898176,Perlmausgrau,Pearl mouse grey,Gris souris nacr�,Gris musgo perlado,Grigio topo perlato,""Parelmoer-muisgrijs""
RAL 8000,130-108-052,#826C34,Gr�nbraun,Green brown,Brun vert,Pardo verdoso,Marrone verdastro,Groenbruin
RAL 8001,149-095-032,#955F20,Ockerbraun,Ochre brown,Brun terre de Sienne,Pardo ocre,Marrone ocra,Okerbruin
RAL 8002,108-059-042,#6C3B2A,Signalbraun,Signal brown,Brun de s�curit�,Marr�n se�ales,Marrone segnale,Signaalbruin
RAL 8003,115-066-034,#734222,Lehmbraun,Clay brown,Brun argile,Pardo arcilla,Marrone fango,Leembruin
RAL 8004,142-064-042,#8E402A,Kupferbraun,Copper brown,Brun cuivr�,Pardo cobre,""Marrone rame"",Koperbruin
RAL 8007,089-053-031,#59351F,Rehbraun,Fawn brown,Brun fauve,Pardo corzo,Marrone capriolo,Reebruin
RAL 8008,111-079-040,#6F4F28,Olivbraun,Olive brown,Brun olive,Pardo oliva,Marrone oliva,Olijfbruin
RAL 8011,091-058-041,#5B3A29,Nussbraun,Nut brown,Brun noisette,Pardo nuez,Marrone noce,Notebruin
RAL 8012,089-035-033,#592321,Rotbraun,Red brown,Brun rouge,Pardo rojo,Marrone rossiccio,Roodbruin
RAL 8014,056-044-030,#382C1E,Sepiabraun,Sepia brown,Brun s�pia,Sepia,Marrone seppia,Sepiabruin
RAL 8015,099-058-052,#633A34,Kastanienbraun,Chestnut brown,Marron,Casta�o,Marrone castagna,Kastanjebruin
RAL 8016,076-047-039,#4C2F27,Mahagonibraun,Mahogany brown,Brun acajou,Caoba,Marrone mogano,Mahoniebruin
RAL 8017,069-050-046,#45322E,""Schokoladen-braun"",Chocolate brown,Brun chocolat,Chocolate,Marrone cioccolata,Chocoladebruin
RAL 8019,064-058-058,#403A3A,Graubraun,Grey brown,Brun gris,Pardo gris�ceo,Marrone grigiastro,Grijsbruin
RAL 8022,033-033-033,#212121,Schwarzbraun,Black brown,Brun noir,Pardo negruzco,Marrone nerastro,Zwartbruin
RAL 8023,166-094-046,#A65E2E,Orangebraun,Orange brown,Brun orang�,Pardo anaranjado,Marrone arancio,Oranjebruin
RAL 8024,121-085-061,#79553D,Beigebraun,Beige brown,Brun beige,Pardo beige,Marrone beige,Beigebruin
RAL 8025,117-092-072,#755C48,Blassbraun,Pale brown,Brun p�le,Pardo p�lido,Marrone pallido,Bleekbruin
RAL 8028,078-059-049,#4E3B31,Terrabraun,Terra brown,Brun terre,Marr�n tierra,Marrone terra,Terrabruin
RAL 8029,118-060-040,#763C28,Perlkupfer,Pearl copper,Cuivre nacr�,Cobre perlado,Rame perlato,Parelmoerkoper
RAL 9001,250-244-227,#FDF4E3,Cremewei�,Cream,Blanc cr�me,Blanco crema,Bianco crema,Cr�mewit
RAL 9002,231-235-218,#E7EBDA,Grauwei�,Grey white,Blanc gris,Blanco gris�ceo,Bianco grigiastro,Grijswit
RAL 9003,244-244-244,#F4F4F4,Signalwei�,Signal white,Blanc de s�curit�,Blanco se�ales,Bianco segnale,Signaalwit
RAL 9004,040-040-040,#282828,Signalschwarz,Signal black,Noir de s�curit�,Negro se�ales,Nero segnale,Signaalzwart
RAL 9005,010-010-013,#0A0A0A,Tiefschwarz,Jet black,Noir fonc�,Negro intenso,Nero intenso,Gitzwart
RAL 9006,165-165-165,#A5A5A5,Wei�aluminium,White aluminium,Aluminium blanc,Aluminio blanco,Aluminio brillante,Blank aluminiumkleurig
RAL 9007,143-143-143,#8F8F8F,Graualuminium,Grey aluminium,Aluminium gris,Aluminio gris,Aluminio grigiastro,Grijs aluminiumkleurig
RAL 9010,255-255-255,#FFFFFF,Reinwei�,Pure white,Blanc pur,Blanco puro,Bianco puro,Zuiverwit
RAL 9011,028-028-028,#1C1C1C,Graphitschwarz,Graphite black,Noir graphite,Negro grafito,Nero grafite,Grafietzwart
RAL 9016,246-246-246,#F6F6F6,Verkehrswei�,Traffic white,Blanc signalisation,Blanco tr�fico,Bianco traffico,Verkeerswit
RAL 9017,030-030-030,#1E1E1E,Verkehrs-schwarz,Traffic black,Noir signalisation,Negro tr�fico,Nero traffico,Verkeerszwart
RAL 9018,207-211-205,#CFD3CD,Papyruswei�,Papyrus white,Blanc papyrus,Blanco papiro,Bianco papiro,Papyruswit
RAL 9022,156-156-156,#9C9C9C,Perlhellgrau,Pearl light grey,Gris clair nacr�,Gris claro perlado,Grigio chiaro perlato,Parelmoer-lichtgrijs
RAL 9023,130-130-130,#828282,Perldunkelgrau,Pearl dark grey,Gris fon�� nacr�,Gris oscuro perlado,Grigio scuro perlato,Parelmoer-donkergrijs";

    public static string GetColumns()
    {
        return RALStandardCodes.Split('\n')[0];
    }

    public static List<RAL> GetRALList()
    {
        List<RAL> ralList = new List<RAL>();

        int i = 0;
        foreach (var l in RALStandardCodes.Split('\n'))
        {
            if (i == 0)
            {
                i++;
                continue;
            }

            var line = l.Split(',');

            int r = int.Parse(line[1].Split('-')[0]);
            int g = int.Parse(line[1].Split('-')[1]);
            int b = int.Parse(line[1].Split('-')[2]);

            var ral = new RAL
            {
                RALCode = line[0],
                RGB = new RGB { r=r, g=g, b=b },
                HEX = line[2],
                German = line[3],
                English = line[4],
                French = line[5],
                Spanish = line[6],
                Italian = line[7],
                Nederlands = line[8]
            };

            ralList.Add(ral);
        }

        return ralList;
    }

    public static RAL FindClosestRAL(List<RAL> list, int r, int g, int b)
    {    
        RAL closestRAL = new RAL();
        int minDifference = int.MaxValue;

        foreach (var ral in list)
        {
            int rDiff = Math.Abs(r - ral.RGB.r);
            int gDiff = Math.Abs(g - ral.RGB.g);
            int bDiff = Math.Abs(b - ral.RGB.b);
            int totalDifference = rDiff + gDiff + bDiff;
            if (totalDifference < minDifference)
            {
                closestRAL = ral;
                minDifference = totalDifference;
            }
        }

        return closestRAL;
    }
}
