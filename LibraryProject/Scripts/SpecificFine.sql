SELECT
  SUM(DECODE(SIGN(EXTRACT(DAY FROM((JOURNAL.DATE_RET - JOURNAL.DATE_END)))),1,(BOOK_TYPES.FINE * EXTRACT(DAY FROM((JOURNAL.DATE_RET - JOURNAL.DATE_END)))),-1,0,0)) AS "TOTAL FINE"
  FROM JOURNAL
  INNER JOIN CLIENTS ON JOURNAL.CLIENT_ID = CLIENTS.ID
  INNER JOIN BOOKS ON JOURNAL.BOOK_ID = BOOKS.ID
  INNER JOIN BOOK_TYPES ON BOOKS.TYPE_ID = BOOK_TYPES.ID
  WHERE JOURNAL.CLIENT_ID = :CLIENT_ID
  GROUP BY CLIENTS.FIRST_NAME, CLIENTS.LAST_NAME, CLIENTS.FATHER_NAME
