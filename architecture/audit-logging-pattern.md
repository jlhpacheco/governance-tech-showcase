# Append-Only Audit Trail Pattern

An append-only audit trail preserves history by adding new events rather than rewriting old ones.

## Core Fields

- Event ID
- Actor ID
- Action
- Timestamp
- Entity reference
- Summary
- Source context

## Design Principle

Historical records should remain stable. Later corrections, reconciliations, or status changes should create new audit events.
