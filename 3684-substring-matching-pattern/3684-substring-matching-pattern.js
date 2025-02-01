/**
 * @param {string} s
 * @param {string} p
 * @return {boolean}
 */
var hasMatch = function(s, p) {
    [a, b] = p.split('*')

    index_a = s.indexOf(a)
    index_b = s.indexOf(b, (index_a + a.length))

    return index_a != -1 && index_b != -1
    
};