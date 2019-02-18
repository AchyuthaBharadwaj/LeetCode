def dfs(y, x, word, board):       
    if not word :
        return True
    
    d = [[0,1],[0,-1],[1,0],[-1,0]]
        
    r = len(board)
    c = len(board[0])
    
    result = False
    
    for i in range(4) :
            
        nr = y + d[i][0]
        nc = x + d[i][1]
            
        if nr < 0 or nr >= r or nc < 0 or nc >= c or word[0] != board[nr][nc]:
            continue
                
        tmp, board[y][x] = board[y][x], "."
        result = result or dfs(nr, nc, word[1:], board)
        board[y][x] = tmp
        
        if result :
            return True
                
    return result
        
    
def exist(board: 'List[List[str]]', word: 'str') -> 'bool':
    
    r = len(board)
    c = len(board[0])
    
    for i in range(r):
        for j in range(c):
            if word[0] == board[i][j] and dfs(i, j, word[1:], board) :
                return True
            
    return False

board = [
  ['A','B','C','E'],
  ['S','F','C','S'],
  ['A','D','E','E']]

print(exist(board, 'ABCB'))