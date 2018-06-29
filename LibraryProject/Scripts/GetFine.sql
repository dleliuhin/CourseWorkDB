    SELECT BOOK_TYPES.DAY_COUNT
    AS CNT
    FROM JOURNAL
    INNER JOIN BOOKS ON JOURNAL.BOOK_ID = BOOKS.ID
    INNER JOIN BOOK_TYPES ON BOOKS.TYPE_ID = BOOK_TYPES.ID
    AND JOURNAL.ID = :ID