import { test, expect } from '@playwright/test';

test('sample public page loads', async ({ page }) => {
  await page.goto('/');
  await expect(page.locator('body')).toBeVisible();
});
