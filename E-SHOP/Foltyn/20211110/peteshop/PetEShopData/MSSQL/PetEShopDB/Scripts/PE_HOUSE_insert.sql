USE PetEShopDB;


INSERT INTO
  PE_HOUSE
  (
    -- ID,
    DESCRIPTION,
    WIDTH,
    LENGTH
  )
  SELECT
    -- 1                               AS ID,
    'Rezidence nad mořem'           AS DESCRIPTION,
    30.0                            AS WIDTH,
    20.0                            AS LENGTH
;


INSERT INTO
  PE_HOUSE
  (
    -- ID,
    DESCRIPTION,
    WIDTH,
    LENGTH
  )
  SELECT
    -- 2                               AS ID,
    'Vila u lesního paloučku'       AS DESCRIPTION,
    10.0                            AS WIDTH,
    10.0                            AS LENGTH
;


INSERT INTO
  PE_HOUSE
  (
    -- ID,
    DESCRIPTION,
    WIDTH,
    LENGTH
  )
  SELECT
    -- 3                               AS ID,
    'Chata'                         AS DESCRIPTION,
    3.5                             AS WIDTH,
    4.0                             AS LENGTH
;


INSERT INTO
  PE_HOUSE
  (
    -- ID,
    DESCRIPTION,
    WIDTH,
    LENGTH
  )
  SELECT
    -- 4                               AS ID,
    'Rodinný dům'                   AS DESCRIPTION,
    20.0                            AS WIDTH,
    25.0                            AS LENGTH
;


