/*
Ex01
return Quaternion.Euler(0, 30, 0);

Ex02
return Quaternion.Inverse(Quaternion.Euler(0, 30, 0));

Ex03
Quaternion.RotateTowards(Quaternion.Euler(0, -30, 0),
                         Quaternion.Euler(0, 30, 0),
                         1);

Ex04
return Quaternion.FromToRotation(Vector3.left, Vector3.right);

Ex05
calcul
Quaternion.Dot(Quaternion.Euler(0, 30, 0), Quaternion.Inverse(Quaternion.Euler(0, 30, 0)));
attendu :
return 9998477;

Ex06
return Quaternion.Slerp(Quaternion.Euler(13, 3, 21), Quaternion.Euler(27, 5, 21), 1);

Ex07
return Quaternion.LookRotation(Vector3.down, Vector3.left);

Ex08
return Quaternion.Euler(08, 07, 47);

Ex09
return Quaternion.Euler(04, 07, 76);

Ex10
return Quaternion.LookRotation(Vector3.up, Vector3.forward);
*/