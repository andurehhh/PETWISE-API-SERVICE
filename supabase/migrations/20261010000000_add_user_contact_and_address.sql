-- Migration: Add nullable contact_number and address columns to "PetWise"."User"
-- Ensures compatibility with existing/legacy user profiles.

ALTER TABLE "PetWise"."User" 
ADD COLUMN IF NOT EXISTS contact_number VARCHAR(20) NULL,
ADD COLUMN IF NOT EXISTS address VARCHAR(255) NULL;
