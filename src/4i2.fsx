let v = (1.3, -2.5)
printfn "Vector %A: (%f, %f)" v (vec2d.len v) (vec2d.ang v)
let w = (-0.1, 0.5)
printfn "Vector %A: (%f, %f)" w (vec2d.len w) (vec2d.ang w)
let s = vec2d.add v w
printfn "Vector %A: (%f, %f)" s (vec2d.len s) (vec2d.ang s)


// Tracing of file
//
// Step | Line  Env.  Bindings & evaluations
// 00   | -     E0    ()
// 01   | 01    E0    v = (1.3, -2.5)
// 02   | 02    E0    Output = "Vector (1.3, -2.5): (?, ?)"
// 03   | 06/fs E1    len = (v = (1.3, -2.5), body, v)
// 04   | 07/fs E1    (x, y) = (1.3, -2.5)
// 05   | 08/fs E1    sqrt(x ** 2.0 + y ** 2.0)
// 06   | 02    E0    Output = "Vector (1.3, -2.5): (2.82, ?)"
// 07   | 12/fs E1    ang = (v = (1.3, -2.5), body, v)
// 08   | 13/fs E1    (x, y) = (1.3, -2.5)
// 09   | 14/fs E1    System.Math.Atan(y, x)
// 10   | 02    E0    Output = "Vector (1.3, -2.5): (2.82, 117.47)"


// 11   | 03    E0    w = (-0.1, 0.5)
// 12   | 04    E0    Output = "Vector (-0.1, 0.5): (?, ?)"
// 13   | 06/fs E1    len = (v = (-0.1, 0.5), body, v)
// 14   | 07/fs E1    (x, y) = (-0.1, 0.5)
// 15   | 08/fs E1    sqrt(x ** 2.0 + y ** 2.0)
// 16   | 04    E0    Output = "Vector (-0.1, 0.5): (0.51, ?)"
// 17   | 12/fs E1    ang = (v = (-0.1, 0.5), body, v)
// 18   | 13/fs E1    (x, y) = (-0.1, 0.5)
// 19   | 14/fs E1    System.Math.Atan(y, x)
// 20   | 14    E0    Output = "Vector (-0.1, 0.5): (0.51, -78.69)"


// 21   | 05    E0    s = ?
// 22   | 18/fs E1    add = (v = (1.3, -2.5), w = (-0.1, 0.5), body, v + w)
// 23   | 19/fs E1    (x1, y1) = v
// 24   | 20/fs E1    (x2, y2) = w
// 25   | 21/fs E1    (x1 + x2, y1 + y2)
// 26   | 05    E1    s = (1.2, -2.0)
// 27   | 06    E0    Output = "Vector (1.2, -2.0): (?, ?)"
// 28   | 06/fs E1    len = (v = (1.2, -2.0), body, v)
// 29   | 07/fs E1    (x, y) = (1.2, -2.0)
// 30   | 08/fs E1    sqrt(x ** 2.0 + y ** 2.0)
// 31   | 06    E0    Output = "Vector (1.2, -2.0): (2.33, ?)"
// 32   | 12/fs E1    ang = (v = (1.2, -2.0), body, v)
// 33   | 13/fs E1    (x, y) = (1.2, -2.0)
// 34   | 14/fs E1    System.Math.Atan(y, x)
// 35   | 06    E0    Output = "Vector (1.2, -2.0): (2.33, 120.96)"



// Overall, the program mostly did what I expected it to.
// The program successfully completed and printed the basic
// operations of calculating the length of a vector,
// and adding two vectors together.
// What I did not expect, however, was the fact that the
// The angles were a little off. This is due to the fact
// that the angles are calculated to be radians.
// This can be fixed by converting the radians to degrees
// before sending the value to the function.
